using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Projeto02_AspNetCore.Models;

namespace Projeto02_AspNetCore.Controllers
{
    public class UsuariosController : Controller
    {
        // Esta variáveis serão instanciadas através de injeção de dependência.
        // As instâncias serão fornecidas pelo próprio framework
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;

        public UsuariosController(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Método para registrar um novo usuário
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registrar(UsuarioViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = new Usuario
                    {
                        UserName = model.Email,
                        Email = model.Email
                    };

                    var result = await _userManager
                        .CreateAsync(user, model.Senha);

                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.Erro = result.Errors.FirstOrDefault().Description;
                        View("Error");
                    }

                }
                catch (Exception ex)
                {
                    ViewBag.Erro = ex.Message;
                    View("Error");
                }

            }

            return View(model);
        }

        // Método para realizar o login
        public IActionResult Login(string ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LogonViewModel model, string ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;

            if (ModelState.IsValid)
            {
                var result = await _signInManager
                    .PasswordSignInAsync(
                        model.Email,
                        model.Senha,
                        true,
                        lockoutOnFailure: false);  // Para não fazer login novamente, sem fazer logout

                if (result.Succeeded)
                {
                    if (ReturnUrl != null)
                    {
                        return Redirect(ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }

                }
            }

            return View(model);
        }

        // Logout
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}