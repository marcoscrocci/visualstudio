using AcessoDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto02_CadastroEventos.Models
{
    public class Colecoes
    {
        public static List<Evento> ListarEventos()
        {
            return new List<Evento>()
            {
                new Evento(){
                    Id =10,
                    Descricao ="Festa",
                    Data =DateTime.Now,
                    Valor =20},

                new Evento(){
                    Id =20,
                    Descricao ="Reunião de Estudo",
                    Data =DateTime.Now,
                    Valor =0},

                new Evento(){
                    Id =30,
                    Descricao ="Show da Anitta",
                    Data =DateTime.Now,
                    Valor =30}
            };
        }
    }
}