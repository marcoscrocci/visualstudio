
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto02_AspNetCore.Models
{
    public class Tratamento
    {
        public int TratamentoId { get; set; }

        [Required]
        public int PacienteId { get; set; }

        [Required]
        [StringLength(50)]
        public string Descricao { get; set; }

        [Required]
        public int Duracao { get; set; }

        [Required]
        public double Preco { get; set; }

    }
}
