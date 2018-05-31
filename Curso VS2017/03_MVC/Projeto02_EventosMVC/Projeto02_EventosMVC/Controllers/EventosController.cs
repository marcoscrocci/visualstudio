using Projeto02_EventosMVC.Db;
using Projeto02_EventosMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto02_EventosMVC.Controllers
{
    public class EventosController : Controller
    {
        // GET: Eventos
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Incluir(Evento evento)
        {
            if (ModelState.IsValid)
            {
                evento.Descricao = evento.Descricao.RetirarAcentos();
                Dados.IncluirEvento(evento);
                ViewBag.Mensagem = "Evento " + evento.Descricao + " adicionado!";
                //return RedirectToAction("Listar");                
                return View("Listar", Dados.ListarEventos());
            }
            else
            {
                return View();
            }           
            
        }

        [Authorize]
        public ActionResult Listar()
        {
            return View(Dados.ListarEventos());
        }

        [Authorize]
        public ActionResult Alterar(int? id)
        {
            if (id == null)
            {
                ViewBag.Erro = "Nenhum parâmetro foi fornecido na URL";
                return View("Erro");
            }
            return View(Dados.BuscarEvento(id));
        }

        [HttpPost]
        public ActionResult Alterar(Evento evento)
        {
            if (ModelState.IsValid)
            {
                evento.Descricao = evento.Descricao.RetirarAcentos();
                Dados.AlterarEvento(evento);
                ViewBag.Mensagem = "Evento " + evento.Descricao + " alterado!";
                //return RedirectToAction("Listar");
                return View("Listar", Dados.ListarEventos());
            }
            return View();
        }

        [Authorize]
        public ActionResult Remover(int? id)
        {
            if (id == null)
            {
                ViewBag.Erro = "Nenhum parâmetro foi fornecido na URL";
                return View("Erro");
            }
            return View(Dados.BuscarEvento(id));
        }

        [HttpPost]
        public ActionResult Remover(Evento evento)
        {
            try
            {
                ViewBag.Mensagem = "Evento removido!";
                Dados.RemoverEvento(evento.Id);
                return View("Listar", Dados.ListarEventos());
            }
            catch (Exception ex)
            {
                string erro = ex.GetBaseException().ToString();
                if (erro.Contains("FK_TBConvidados_TBEventos"))
                {
                    ViewBag.Erro = "Não é permitido remover eventos que contenham convidados vinculados.";
                }
                else
                {
                    ViewBag.Erro = "ERRO: " + ex.Message + "\nDetalhes: " + erro;
                }                
                return View("Erro");
            }
        }


        

    }
}