using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiPagamentos.Models
{
    public class PagamentosRepositorio : IPagamentosRepositorio
    {
        public TBPagamentos Adicionar(TBPagamentos pagamento)
        {
            using (var ctx = new PagamentosEntities())
            {
                var pagto = ctx.TBPagamentos
                    .FirstOrDefault(p => p.NumeroCartao == pagamento.NumeroCartao
                        && p.IdConvidado == pagamento.IdConvidado
                        && p.Valor == pagamento.Valor);

                if (pagto == null)
                {
                    ctx.TBPagamentos.Add(pagamento);
                    ctx.SaveChanges();
                    return pagamento;
                }

                return null;
            }
        }

        public TBPagamentos Buscar(int id)
        {
            using (var ctx = new PagamentosEntities())
            {
                return ctx.TBPagamentos.FirstOrDefault(p => p.Id == id);
            }
        }

        public ICollection<TBPagamentos> ListarTodos()
        {
            using (var ctx = new PagamentosEntities())
            {
                return ctx.TBPagamentos.ToList<TBPagamentos>();
            }
        }

        public void Remover(TBPagamentos pagamento)
        {
            throw new NotImplementedException();
        }

        public TBCartoes BuscarCartao(string numeroCartao)
        {
            using (var ctx = new PagamentosEntities())
            {
                return ctx.TBCartoes.FirstOrDefault(p => p.NumeroCartao == numeroCartao);
            }
        }

        public void AtualizarCartao(TBCartoes cartao)
        {
            using (var ctx = new PagamentosEntities())
            {
                ctx.Entry<TBCartoes>(cartao).State = EntityState.Modified;
                ctx.SaveChanges();
            }
            
        }
    }
}