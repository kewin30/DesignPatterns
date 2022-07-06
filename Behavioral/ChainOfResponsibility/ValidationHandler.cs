using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class ValidationHandler :BaseHandler
    {
        public ValidationHandler(IHandler next):base(next)
        {

        }

        public override void Handle(RequestContext requestContext)
        {
            if(requestContext.Request.EntityId>100)
            {
                _next.Handle(requestContext);
                return;
            }
            requestContext.Response.IsSuccesful = false;
            requestContext.Response.Message = "Validation error: ID less than 100";
        }
    }
}
