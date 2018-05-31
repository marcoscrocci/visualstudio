using Newtonsoft.Json;
using Projeto02_EventosMVC.Db;
using Projeto02_EventosMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Projeto02_EventosMVC.Controllers
{
    public class PagamentosController : Controller
    {
        HttpClient client; // System.Net.Http (Adicionar referência)
        string msg = "";

        public PagamentosController()
        {
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:51395/");
                //MIME Type
                client.DefaultRequestHeaders.Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        // GET: Pagamentos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EfetuarPagamento()
        {
            ViewBag.ListaConvidados = new SelectList(Dados.ListarTodosConvidados(), "Id", "Nome");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> EfetuarPagamento(PagamentoEvento pagamento)
        {
            if (!ModelState.IsValid)
            {
                return EfetuarPagamento();
            }

            pagamento.Valor = Dados.BuscarValorEvento(pagamento.IdConvidado);
            if (pagamento.Valor <= 0)
            {
                ViewBag.Erro = "Não existem valores a serem pagos";
                return View("Erro");
            }

            try
            {
                // Criação de um json com base no objeto
                string json = JsonConvert.SerializeObject(pagamento);

                // Serialização do conteúdo json para fluxo de bytes
                HttpContent content = new StringContent(json, Encoding.Unicode, "application/json");
                var response = await client.PostAsync("api/Pagamentos", content);

                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Sucesso = "Pagamento realizado com sucesso!";
                    return View("Sucesso");
                }
                else
                {
                    msg = response.StatusCode + " - " + response.ReasonPhrase;
                    ViewBag.Erro = msg;
                    return View("Erro");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Erro = ex.Message;
                return View("Erro");
            }
                        
        }

        public async Task<ActionResult> ListarPagamentos()
        {
            try
            {
                HttpResponseMessage response = client.GetAsync("api/pagamentos").Result;
                if (response.IsSuccessStatusCode)
                {
                    var resultado = await response.Content.ReadAsStringAsync();

                    var lista = JsonConvert
                        .DeserializeObject<PagamentoEvento[]>(resultado)
                        .ToList<PagamentoEvento>();

                    return View(lista);
                }
                else
                {
                    msg = response.StatusCode + " - " + response.ReasonPhrase;
                    ViewBag.Erro = msg;
                    return View("Erro");
                }
            }
            catch (Exception ex)
            {
                ViewBag.Erro = ex.Message;
                return View("Erro");
            }
            
        }

    }
}