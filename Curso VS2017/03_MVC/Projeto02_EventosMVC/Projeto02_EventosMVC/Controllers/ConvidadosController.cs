using Projeto02_EventosMVC.Db;
using Projeto02_EventosMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Projeto02_EventosMVC.Controllers
{
    public class ConvidadosController : Controller
    {
        // GET: Convidados
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Incluir()
        {
            //ViewData["ListaEventos"] = new SelectList(Dados.ListarEventos(), "Id", "Descricao");  // MVC 1 e 2.
            ViewBag.ListaEventos = new SelectList(Dados.ListarEventos(), "Id", "Descricao");
            return View();
        }

        [HttpPost]
        public ActionResult Incluir(Convidado convidado)
        {
            if (ModelState.IsValid)
            {
                Dados.IncluirConvidado(convidado);
                return RedirectToAction("Index");
            }
            return Incluir();
        }

        [Authorize]
        public ActionResult Listar(int? id)
        {
            ViewBag.ListaEventos = new SelectList(Dados.ListarEventos(), "Id", "Descricao");
            return View(Dados.ListarConvidadosLinq(id));
        }

        [Authorize]
        public ActionResult ListarPorEvento(int? id)
        {
            if (Request.IsAjaxRequest())
            {
                var lista = Dados.ListarConvidadosLinq(id);
                return PartialView("_ListaConvidados", lista);
            }
            else
            {
                ViewBag.ListaEventos = new SelectList(Dados.ListarEventos(), "Id", "Descricao");
                return View();
            }            
        }

        [Authorize]
        public ActionResult RegistrarContato(string email)
        {
            // Obtém o objeto Convidado com base no email, 
            // representado pelo parâmetro id
            Convidado convidado = Dados.BuscarConvidado(email);
            if (convidado != null)
            {
                Contato contato = new Contato();
                contato.IdConvidado = convidado.Id;
                ViewBag.NomeConvidado = convidado.Nome;
                return View(contato);
            }
            ViewBag.Erro = "Nenhum contato com este email";
            return View("Erro");
        }

        [HttpPost]
        public ActionResult RegistrarContato(string email, Contato contato)
        {
            try
            {
                contato.DataContato = DateTime.Now;
                DadosContato.AdicionarContato(contato);
                
                return RedirectToAction("Listar");
            }
            catch (Exception ex)
            {
                ViewBag.Erro = ex.Message;
                return View("Erro");                
            }
            

        }

        [Authorize]
        public ActionResult Visualizar()
        {            
            return View(Dados.ListarTodosConvidados());
        }

        public ActionResult MostrarMensagem(int id)
        {
            return View(DadosContato.BuscarContato(id));
        }

    }
}