using Projeto02_EventosMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto02_EventosMVC.Db
{
    public class DadosContato
    {
        public static void AdicionarContato(Contato contato)
        {
            using (var ctx = new ContatosDbContext())
            {
                ctx.Contatos.Add(contato);
                ctx.SaveChanges();
            }
        }

        // Método que retorna um Contato com base do id do Convidado.
        public static Contato BuscarContato(int idConvidado)
        {
            using (var ctx = new ContatosDbContext())
            {
                Contato contato = ctx.Contatos.FirstOrDefault(c => c.IdConvidado == idConvidado);
                if (contato == null) // contato /mensagem não encontrado para este convidado
                {
                    return new Contato()
                    {
                        Id = -1,
                        IdConvidado = idConvidado,
                        DataContato = DateTime.Now,
                        Mensagem = "Nenhuma mensagem para este convidado"
                    };
                } else {
                    return contato;
                }
            }            
        }

    }
}