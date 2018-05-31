using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto02_EventosMVC.Models
{
    public class LoginUsuario
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6)]
        public string Senha { get; set; }
    }
}