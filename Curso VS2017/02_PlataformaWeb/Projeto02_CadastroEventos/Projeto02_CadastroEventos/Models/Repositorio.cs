using AcessoDados.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto02_CadastroEventos.Models
{
    public class Repositorio
    {
        static EventosDao eventosDao;
        static ConvidadosDao convidadosDao;

        public static EventosDao GetEventosDao()
        {
            if (eventosDao == null)
            {
                eventosDao = new EventosDao();
            }
            return eventosDao;
        }

        public static ConvidadosDao GetConvidadosDao()
        {
            if (convidadosDao == null)
            {
                convidadosDao = new ConvidadosDao();
            }
            return convidadosDao;
        }


    }
}