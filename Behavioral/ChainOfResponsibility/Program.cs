using System;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RequestContext requestContext = new RequestContext()
            {
                Request = new Request()
                {
                    EntityId = 101,
                    UserId = 13,
                    UserRole = "Admin"
                },
                Response = new Response()
            };

            ResultHandler resultHandler = new ResultHandler(null);
            ValidationHandler validationHandler = new ValidationHandler(resultHandler);
            AuthorizationHandler authorizationHandler = new AuthorizationHandler(validationHandler);

            authorizationHandler.Handle(requestContext);
            Console.WriteLine($"IsSuccesful: {requestContext.Response.IsSuccesful}");
            Console.WriteLine($"Message: {requestContext.Response.Message}");
            Console.WriteLine($"Data: {requestContext.Response.Data}");
        }
    }
}
