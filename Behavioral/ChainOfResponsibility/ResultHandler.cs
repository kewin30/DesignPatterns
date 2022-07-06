using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class ResultHandler : BaseHandler
    {
        public ResultHandler(IHandler next):base(next)
        {

        }

        public override void Handle(RequestContext requestContext)
        {
            requestContext.Response.IsSuccesful = true;
            requestContext.Response.Data = "Some value";
        }
    }
}
