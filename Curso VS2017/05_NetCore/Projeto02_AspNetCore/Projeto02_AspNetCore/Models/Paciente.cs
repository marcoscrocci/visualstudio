using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto02_AspNetCore.Models
{
    public class Paciente
    {
        public int PacienteId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(20)]
        public string Telefone { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        [Required]
        [StringLength(50)]
        public string Convenio { get; set; }

        [Required]
        [MaxLength]
        public byte[] Foto { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string FotoMimeType { get; set; }

        public ICollection<Tratamento> Tratamentos { get; set; }


    }
}
