using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04_AppClientes.Classes
{
    public class ClientePF: Cliente
    {
        private string _documento;
        public override string NumeroDocumento
        {
            get { return _documento; }
            set
            {
                if (value.Length != 11)
                {
                    throw new Exception("CPF deve ter 11 dígitos");
                }
                _documento = value;
            }
        }

        
    }
}
