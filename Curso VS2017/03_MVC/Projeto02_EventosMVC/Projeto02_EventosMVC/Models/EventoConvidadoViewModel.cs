using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto02_EventosMVC.Models
{
    public class EventoConvidadoViewModel
    {
        public int IdEvento { get; set; }
        public string DescricaoEvento { get; set; }
        //public int IdConvidado { get; set; }
        public string NomeConvidado { get; set; }
        public string EmailConvidado { get; set; }

        // Contrutor
        public EventoConvidadoViewModel(int idEvento, string descricao, string nome, string email)
        {
            this.IdEvento = idEvento;
            this.DescricaoEvento = descricao;
            this.NomeConvidado = nome;
            this.EmailConvidado = email;
        }
    }
}