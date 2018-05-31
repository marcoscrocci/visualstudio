//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto02_EventosMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Convidado
    {
        public int Id { get; set; }

        [Display(Name = "Evento")]
        public int IdEvento { get; set; }

        [Required(ErrorMessage = "O nome do convidado � obrigat�rio")]
        [Display(Name = "Nome do Convidado")]
        public string Nome { get; set; }

        //[DataType(DataType.EmailAddress)]
        [Display(Name = "Email do Convidado")]
        [Required(ErrorMessage = "O email do convidado � obrigat�rio")]        
        [RegularExpression(@"^[a-zA-Z0-9\._\-]+\@+[a-zA-Z0-9\._\-]+\.[a-zA-Z]+$", ErrorMessage = "Email inv�lido")]

        public string Email { get; set; }
    
        public virtual Evento EventoInfo { get; set; }
    }
}
