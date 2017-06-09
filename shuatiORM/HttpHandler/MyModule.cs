using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace HttpModule
{
    public class MyModule : IHttpModule
    {
        public void Init(HttpApplication application)
        {
            application.BeginRequest += new EventHandler(application_BeginRequest);
        }

        void application_BeginRequest(object sender, EventArgs e)
        {
            ((HttpApplication)sender).Response.Write("Copyright @Gspring<br/>");
        }

        public void Dispose()
        {
        }

        public void ProcessRequest(HttpContext ctx)
        {
            string controller = ctx.Request.QueryString["controller"];
            string action = ctx.Request.QueryString["action"];

            string url1 = ctx.Request.Url.ToString();
            if (url1.EndsWith(".aspx"))
            {
                string url2 = url1 + ".aspx";
                ctx.Response.Redirect(url2);
            }
            //ctx.Response.Write("Copyright @Gspring<br/>");
        }
        public bool IsReusable
        {
            get { return true; }
        }
    }
}
