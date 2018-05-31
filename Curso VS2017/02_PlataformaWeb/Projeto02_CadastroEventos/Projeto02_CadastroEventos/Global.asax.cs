using Microsoft.AspNet.FriendlyUrls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Projeto02_CadastroEventos
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.EnableFriendlyUrls();
            BundleTable.Bundles.Add(new StyleBundle("~/estilos")
                .Include("~/Css/Estilos.css",
                    "~/Content/bootstrap.min.css"));
            BundleTable.EnableOptimizations = true;
        }
    }
}