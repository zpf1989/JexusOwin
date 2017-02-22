using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace JexusOwin
{
    [AllowAnonymous]
    public class DefaultController : ApiController
    {
        [HttpGet]
        public string Hello()
        {
            return "hello Owin！";
        }
    }
}
