using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiPagamentos.Enumeracoes;

namespace WebApiPagamentos.Models
{
    public class PagamentosRepositorio : IPagamentosRepositorio
    {
        public StatusPagamento Adicionar(TBPagamentos pagamento)
        {
            using(var ctx = new PagamentosEntities())
            {
                var pagto = ctx.TBPagamentos
                    .FirstOrDefault(
                        p => p.NumeroCartao == pagamento.NumeroCartao
                        && p.IdConvidado  == pagamento.IdConvidado 
                        && p.Valor == pagamento.Valor);

                if(pagto == null) //pagto ainda não realizado
                {
                    if (!VerificarCartao(pagamento.NumeroCartao))
                    {
                        return StatusPagamento.CARTAO_INEXISTENTE;
                    }
                    if (!AtualizarLimite(pagamento))
                    {
                        return StatusPagamento.SALDO_INDISPONIVEL;
                    }

                    ctx.TBPagamentos.Add(pagamento);
                    ctx.SaveChanges();
                    return StatusPagamento.PAGTO_OK;
                }
                return StatusPagamento.PAGTO_EFETUADO;
            }
        }

        public TBPagamentos Buscar(int id)
        {
            using(var ctx = new PagamentosEntities())
            {
                return ctx.TBPagamentos.FirstOrDefault(p => p.Id == id);
            }
        }

        public ICollection<TBPagamentos> ListarTodos()
        {
            using(var ctx = new PagamentosEntities())
            {
                return ctx.TBPagamentos.ToList<TBPagamentos>();
            }
        }

        public void Remover(TBPagamentos pagamento)
        {
            throw new NotImplementedException();
        }

        //Métodos criados além da interface
        public bool VerificarCartao(string cartaoCliente)
        {
            using(var ctx = new PagamentosEntities())
            {
                return ctx
                    .TBCartoes
                    .FirstOrDefault(p =>
                    p.NumeroCartao.Equals(cartaoCliente)) != null;
            }
        }

        public bool AtualizarLimite(TBPagamentos pagamento)
        {
            using(var ctx = new PagamentosEntities())
            {
                if (VerificarCartao(pagamento.NumeroCartao))
                {
                    TBCartoes cartao = ctx
                        .TBCartoes
                        .FirstOrDefault(p =>
                            p.NumeroCartao
                            .Equals(pagamento.NumeroCartao));

                    if(pagamento.Valor <= cartao.Limite)
                    {
                        cartao.Limite -= pagamento.Valor;
                        ctx.Entry<TBCartoes>(cartao).State =
                            EntityState.Modified;
                        ctx.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
        }
    }
}