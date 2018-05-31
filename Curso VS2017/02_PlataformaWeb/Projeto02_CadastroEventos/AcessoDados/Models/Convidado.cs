using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Models
{
    public class Convidado
    {
        public int Id { get; set; }
        public int IdEvento { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Evento InfoEvento { get; set; }
    }
}
