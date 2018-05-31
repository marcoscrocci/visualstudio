using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiPagamentos.Models;

namespace WebApiPagamentos.Controllers
{
    public class PagamentosController : ApiController
    {
        static readonly IPagamentosRepositorio repo = new PagamentosRepositorio();

        // Operação: HTTP GET - Listar todos os pagamentos
        public IEnumerable<TBPagamentos> GetPagamentos()
        {
            return repo.ListarTodos();
        }

        // Operação: HTTP POST - Inclusão de um pagamento
        public HttpResponseMessage PostPagamento(TBPagamentos pagto)
        {
            // Verificar se o pagto.NumeroCartao é válido
            var cartao = repo.BuscarCartao(pagto.NumeroCartao);
            if (cartao == null)
            {
                var erro = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Erro no servidor"),
                    ReasonPhrase = "Número de cartão inválido"
                };
                throw new HttpResponseException(erro);
            }
            else
            {
                if (pagto.Valor > cartao.Limite)
                {
                    var erro = new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Erro no servidor"),
                        ReasonPhrase = "Não foi possível realizar o pagamento. Limite de valor excedido."
                    };
                    throw new HttpResponseException(erro);
                }
                else
                {
                    cartao.Limite -= pagto.Valor;
                    repo.AtualizarCartao(cartao);
                }
            }

            TBPagamentos resposta = repo.Adicionar(pagto);
            

            if (resposta == null) // pagamento já efetuado
            {
                var erro = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Erro no servidor"),
                    ReasonPhrase = "O pagamento já foi efetuado"
                };
                throw new HttpResponseException(erro);
            }

            // Caso contrário, o pagamento é efetuado
            var response = Request.CreateResponse<TBPagamentos>(HttpStatusCode.Created, pagto);

            string uri = Url.Link("DefaultApi", new { id = pagto.Id });
            response.Headers.Location = new Uri(uri);
            return response;

        }


    }
}
