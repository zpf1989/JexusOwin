using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace JexusOwin
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var httpConfig = new HttpConfiguration();
            httpConfig.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );
            //强制设定目前的WebApi返回格式为json
            httpConfig.Formatters.Remove(httpConfig.Formatters.XmlFormatter);
            //加载webapi中间件
            app.UseWebApi(httpConfig);
        }
    }
}
