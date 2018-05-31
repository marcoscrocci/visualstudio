using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04_AppClientes
{
    public interface IRelatorio
    {
        string Assunto { get; set; }

        string Imprimir();
    }
}
