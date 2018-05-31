using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiPagamentos.Enumeracoes;

namespace WebApiPagamentos.Models
{
    public interface IPagamentosRepositorio
    {
        StatusPagamento Adicionar(TBPagamentos pagamento);
        ICollection<TBPagamentos> ListarTodos();
        TBPagamentos Buscar(int id);
        void Remover(TBPagamentos pagamento);
    }
}
