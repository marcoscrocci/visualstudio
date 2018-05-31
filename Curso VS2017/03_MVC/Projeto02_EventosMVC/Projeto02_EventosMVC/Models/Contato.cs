using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto02_EventosMVC.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public int IdConvidado { get; set; }
        public DateTime DataContato { get; set; }
        public string Mensagem { get; set; }

    }
}