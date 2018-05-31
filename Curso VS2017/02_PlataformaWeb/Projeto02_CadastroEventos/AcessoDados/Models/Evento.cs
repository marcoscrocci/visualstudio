using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string Responsavel { get; set; }
        public double Valor { get; set; }
        public ICollection<Convidado> Convidados { get; set; }
    }
}
