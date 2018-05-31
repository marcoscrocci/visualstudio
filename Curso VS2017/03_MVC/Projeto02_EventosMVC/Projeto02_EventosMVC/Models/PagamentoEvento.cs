using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto02_EventosMVC.Models
{
    public class PagamentoEvento
    {
        public int Id { get; set; }
        public int IdConvidado { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 16)]
        public string NumeroCartao { get; set; }

        [Required]
        public double Valor { get; set; }
    }
}