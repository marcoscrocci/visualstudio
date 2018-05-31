using AcessoDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AcessoDados.Data
{
    public class ConvidadosDao : Dao<Convidado>
    {
        public override Convidado Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Incluir(Convidado elemento)
        {
            try
            {
                AbrirConexao();
                //StringBuilder sb = new StringBuilder();
                cmd.CommandText =
                    @"INSERT INTO TBConvidados  
                        (IdEvento, Nome, Email)
                      VALUES 
                        (@IdEvento, @Nome, @Email);
                    ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdEvento", elemento.IdEvento);
                cmd.Parameters.AddWithValue("@Nome", elemento.Nome);
                cmd.Parameters.AddWithValue("@Email", elemento.Email);                
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                FecharConexao();
            }

        }

        public override DataTable Listar(int id = -1)
        {
            DataTable dt = new DataTable();

            try
            {
                AbrirConexao();
                StringBuilder sb = new StringBuilder();
                sb.Append(@"SELECT c.Id,
                                   c.IdEvento,
	                               c.Nome,
	                               c.Email,
	                               e.Descricao as Evento
                            FROM   TBConvidados c
                            INNER JOIN TBEventos e on e.Id = c.IdEvento ");
                cmd.Parameters.Clear();
                if (id > 0)
                {
                    sb.Append("WHERE c.IdEvento = @IdEvento ");
                    cmd.Parameters.AddWithValue("@IdEvento", id);
                }
                cmd.CommandText = sb.ToString();
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                FecharConexao();
            }

            return dt;
        }
    }
}
