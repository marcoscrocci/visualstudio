using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace WebGearHost.Controllers
{
    public class IdiomaController : Controller
    {
        // GET: Idioma
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Mudar(String IdiomaAbreviacao)
        {
            if (IdiomaAbreviacao != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(IdiomaAbreviacao);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(IdiomaAbreviacao);
            }

            HttpCookie cookie = new HttpCookie("Idioma");
            cookie.Value = IdiomaAbreviacao;
            Response.Cookies.Add(cookie);

            return View("Index");
        }
    }

    
}
