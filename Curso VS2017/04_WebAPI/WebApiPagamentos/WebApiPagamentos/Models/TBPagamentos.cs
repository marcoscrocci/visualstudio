//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiPagamentos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBPagamentos
    {
        public int Id { get; set; }
        public int IdConvidado { get; set; }
        public string NumeroCartao { get; set; }
        public double Valor { get; set; }
    }
}