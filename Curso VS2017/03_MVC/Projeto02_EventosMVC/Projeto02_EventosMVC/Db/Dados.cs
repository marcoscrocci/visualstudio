using Projeto02_EventosMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projeto02_EventosMVC.Db
{
    public class Dados
    {
        #region Gestão de Eventos
        //Eventos
        //Incluir novo Evento
        public static void IncluirEvento(Evento evento)
        {
            using (var ctx = new DBEVENTOSEntities())
            {
                ctx.Eventos.Add(evento);
                ctx.SaveChanges(); // realiza o sincronismo com o banco de dados.
            } 
        }

        //Listar todos os Eventos
        public static List<Evento> ListarEventos()
        {
            using (var ctx = new DBEVENTOSEntities())
            {
                return ctx.Eventos.ToList<Evento>();
            }
        }

        public static List<Evento> ListarEventosLinq()
        {
            var ctx = new DBEVENTOSEntities();
            var resultado = from ev in ctx.Eventos
                            orderby ev.Descricao
                            select ev;
            return resultado.ToList<Evento>();
        }

        //Buscar um Evento pelo Id
        public static Evento BuscarEvento(int? id)
        {
            using (var ctx = new DBEVENTOSEntities())
            {
                return ctx.Eventos.FirstOrDefault(p => p.Id == id);
            }
        }

        //Alterar um Evento
        public static void AlterarEvento(Evento evento)
        {
            using (var ctx = new DBEVENTOSEntities())
            {
                ctx.Entry<Evento>(evento).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public static void RemoverEvento(int id)
        {
            try
            {
                using (var ctx = new DBEVENTOSEntities())
                {
                    Evento evento = ctx.Eventos.FirstOrDefault(p => p.Id == id);

                    if (evento != null)
                    {
                        ctx.Entry<Evento>(evento).State = EntityState.Deleted;
                        ctx.SaveChanges();
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Gestão de Convidados
        //Convidados
        //Incluir novo Convidado
        public static void IncluirConvidado(Convidado convidado)
        {
            using (var ctx = new DBEVENTOSEntities())
            {
                ctx.Convidados.Add(convidado);
                ctx.SaveChanges(); // realiza o sincronismo com o banco de dados.
            }
        }

        // Método para listar os convidados, com a descrição do evento (usaremos join)
        public static List<EventoConvidadoViewModel> ListarConvidados(int? idEvento)
        {
            using (var ctx = new DBEVENTOSEntities())
            {
                var resultado = ctx.Eventos  // Tabela Original
                    .Join(ctx.Convidados,    // Tabela com a qual fazemos o join
                    e => e.Id,               // campo da tabela original
                    c => c.IdEvento,         // campo da tabela segundária
                    (e, c) =>                // união dos campos
                    new                      // definição do objeto anônimo:
                    {
                        IdEvento = e.Id,
                        Descricao = e.Descricao + " (" + e.Responsavel + ")",
                        Nome = c.Nome,
                        Email = c.Email
                    });

                List<EventoConvidadoViewModel> lista = new List<EventoConvidadoViewModel>();

                foreach (var item in resultado)
                {
                    if (idEvento != null && idEvento == item.IdEvento)
                    {                    
                        lista.Add(new EventoConvidadoViewModel(
                            item.IdEvento, item.Descricao, item.Nome, item.Email));
                    }
                }

                return lista.Where(p => 
                    (idEvento == null ? p.IdEvento > 0 : p.IdEvento == idEvento))
                    .ToList<EventoConvidadoViewModel>();
                
                /* //Outra opção:
                if (idEvento == null)
                {
                    return lista;
                }
                else
                {
                    return lista.Where(p => p.IdEvento == idEvento).ToList();
                }
                */
            }
        }

        public static List<EventoConvidadoViewModel> ListarConvidadosLinq(int? idEvento)
        {
            var ctx = new DBEVENTOSEntities();

            var resultado = from e in ctx.Eventos
                            join c in ctx.Convidados
                            on e.Id equals c.IdEvento
                            where (idEvento == null ? c.IdEvento > 0 : c.IdEvento == idEvento)
                            select new
                            {
                                IdEvento = e.Id,
                                Descricao = e.Descricao + " (" + e.Responsavel + ")",
                                Nome = c.Nome,
                                Email = c.Email
                            };

            List<EventoConvidadoViewModel> lista = new List<EventoConvidadoViewModel>();

            foreach (var item in resultado)
            {
                lista.Add(new EventoConvidadoViewModel(
                    item.IdEvento, item.Descricao, item.Nome, item.Email));
            }

            return lista;
        }

        // Método para buscar um convidado pelo email
        public static Convidado BuscarConvidado(string email)
        {
            using (var ctx = new DBEVENTOSEntities())
            {
                return ctx.Convidados.FirstOrDefault(c => c.Email.Equals(email));
            }
        }

        // Método para listar os convidados pelo nome e seu id
        public static List<Convidado> ListarTodosConvidados()
        {
            using (var ctx = new DBEVENTOSEntities())
            {
                return ctx.Convidados.ToList<Convidado>();
            }
        }

        // Método para obter o valor do evento onde o convidado se inscreveu
        public static double BuscarValorEvento(int idConvidado)
        {
            double valor = 0;

            using (var ctx = new DBEVENTOSEntities())
            {
                var convidado = ctx.Convidados.FirstOrDefault(p => p.Id == idConvidado);

                if (convidado != null)
                {
                    valor = ctx.Eventos.FirstOrDefault(p => p.Id == convidado.IdEvento).Valor;
                }                
            }

            return valor;
        }

        #endregion


    }
}