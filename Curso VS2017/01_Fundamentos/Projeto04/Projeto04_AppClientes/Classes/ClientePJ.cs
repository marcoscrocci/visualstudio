using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04_AppClientes.Classes
{
    public class ClientePJ: Cliente
    {
        private string _documento;
        public override string NumeroDocumento
        {
            get { return _documento; }
            set
            {
                if (value.Length != 14)
                {
                    throw new Exception("CNPJ deve ter 14 dígitos");
                }
                _documento = value;
            }
        }
    }
}
