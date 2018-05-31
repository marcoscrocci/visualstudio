using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiPagamentos.Enumeracoes;
using WebApiPagamentos.Models;

namespace WebApiPagamentos.Controllers
{
    public class PagamentosController : ApiController
    {
        static readonly IPagamentosRepositorio repo =
            new PagamentosRepositorio();

        //Operação: HTTP GET - Listar todos os pagamentos
        public IEnumerable<TBPagamentos> GetPagamentos()
        {
            return repo.ListarTodos();
        }

        //Operação: HTTP POST - Inclusão de um pagamento
        public HttpResponseMessage PostPagamento(TBPagamentos pagto)
        {
            StatusPagamento resposta = repo.Adicionar(pagto);

            if (resposta == StatusPagamento.PAGTO_OK)
            {
                var response = Request
                    .CreateResponse<TBPagamentos>(HttpStatusCode.Created, pagto);

                string uri = Url.Link("DefaultApi", new { id = pagto.Id });
                response.Headers.Location = new Uri(uri);
                return response;
            }
            else
            {
                string mensagem = "";
                switch (resposta)
                {
                    case StatusPagamento.CARTAO_INEXISTENTE:
                        {
                            mensagem = "Este cartão não existe na base de dados";
                        };break;
                    case StatusPagamento.SALDO_INDISPONIVEL:
                        {
                            mensagem = "Saldo indisponível para este pagamento";
                        };break;
                    default:
                        {
                            mensagem = "O pagamento já foi realizado";
                        };break;
                }

                var erro = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Erro no servidor"),
                    ReasonPhrase = mensagem
                };
                throw new HttpResponseException(erro);
            }





            //if (resposta == null) //pagamento já efetuado
            //{
            //    var erro = new HttpResponseMessage(HttpStatusCode.BadRequest)
            //    {
            //        Content = new StringContent("Erro no servidor"),
            //        ReasonPhrase = "O pagamento já foi efetuado"
            //    };
            //    throw new HttpResponseException(erro);
            //}

            //caso contrário, o pagamento é efetuado
            //var response = Request
            //    .CreateResponse<TBPagamentos>(HttpStatusCode.Created,pagto);

            //string uri = Url.Link("DefaultApi", new { id = pagto.Id });
            //response.Headers.Location = new Uri(uri);
            //return response;
        }
    }
}
