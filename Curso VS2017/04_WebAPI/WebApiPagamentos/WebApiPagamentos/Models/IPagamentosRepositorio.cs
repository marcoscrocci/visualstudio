using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiPagamentos.Models
{
    interface IPagamentosRepositorio
    {
        TBPagamentos Adicionar(TBPagamentos pagamento);
        ICollection<TBPagamentos> ListarTodos();
        TBPagamentos Buscar(int id);
        void Remover(TBPagamentos pagamento);
        TBCartoes BuscarCartao(string numeroCartao);
        void AtualizarCartao(TBCartoes cartao);

    }
}
