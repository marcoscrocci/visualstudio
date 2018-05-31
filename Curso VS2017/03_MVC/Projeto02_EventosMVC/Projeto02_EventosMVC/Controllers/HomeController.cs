using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Projeto02_EventosMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto02_EventosMVC.Controllers
{
    public class HomeController : Controller
    {
        public string ExibirCurso()
        {
            return "Desenvolvimento Web";
        }

        public ActionResult MostrarPdf()
        {
            return File("~/pdf/Apresentacao_VS2017_Emilio.pdf", "application/pdf");
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();            
        }

        public ViewResult Conteudo()
        {
            return View();
        }

        // Actions destinados à segurança.
        public ActionResult Login()
        {
            // Senha utilizada no curso: 123456
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginUsuario usuario, string ReturnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var usuarioStore = new UserStore<IdentityUser>();
            var usuarioManager = new UserManager<IdentityUser>(usuarioStore);
            var usuarioInfo = usuarioManager.Find(usuario.Nome, usuario.Senha);

            if (usuarioInfo != null)
            {
                var autManager = System.Web.HttpContext.Current.GetOwinContext().Authentication;
                var identityUsuario = usuarioManager.CreateIdentity(usuarioInfo, 
                        DefaultAuthenticationTypes.ApplicationCookie);
                autManager.SignIn(new AuthenticationProperties()
                {
                    IsPersistent = false
                }, identityUsuario);

                if (ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                else
                { 
                    return Redirect("Index"); // ou RedirectToAction
                }
            }
            else
            {
                ViewBag.Erro = "Usuario ou senha inválidos";
                return View();
            }

        }


        public ActionResult Logout()
        {
            var autManager = System.Web.HttpContext.Current
                .GetOwinContext().Authentication;
            autManager.SignOut();

            return RedirectToAction("Index");
        }

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(CadastroUsuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            // Objeto que representa o usuário no banco de dados
            var usuarioStore = new UserStore<IdentityUser>();

            // Objeto que manipula o usuário definido anteriormente:
            // Cria o usuário, realiza login, logout, atribuir papéis, ...
            var usuarioManager = new UserManager<IdentityUser>(usuarioStore);

            // Criar a identidade
            var usuarioInfo = new IdentityUser()
            {
                UserName = usuario.Nome
            };

            // Criar o usuário no banco de dados
             IdentityResult resultado = usuarioManager.Create(usuarioInfo, usuario.Senha);

            // Se o usuário foi criado, o autentica
            if (resultado.Succeeded)
            {
                // Autentica e volta para a página inicial
                var autManager = System.Web.HttpContext.Current.GetOwinContext().Authentication;
                var identidadeUsuario = usuarioManager.CreateIdentity(usuarioInfo, DefaultAuthenticationTypes.ApplicationCookie);

                autManager.SignIn(new AuthenticationProperties() { }, identidadeUsuario);

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Erro = resultado.Errors.FirstOrDefault();
                return View();
            }
            
        }

    }
}