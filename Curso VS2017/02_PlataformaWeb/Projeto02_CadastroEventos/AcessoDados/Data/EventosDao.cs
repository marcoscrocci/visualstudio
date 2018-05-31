using AcessoDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AcessoDados.Data
{
    public class EventosDao : Dao<Evento>
    {
        public override Evento Buscar(int id)
        {
            Evento evento = new Evento();

            try
            {
                AbrirConexao();
                

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                FecharConexao();
            }

            return evento;
        }

        public override void Incluir(Evento elemento)
        {
            try
            {
                AbrirConexao();
                //StringBuilder sb = new StringBuilder();                
                cmd.CommandText =
                    @"INSERT INTO TBEventos  
                        (Data, Descricao, Responsavel, Valor)
                      VALUES 
                        (@Data, @Descricao, @Responsavel, @Valor);
                    ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Data", elemento.Data);
                cmd.Parameters.AddWithValue("@Descricao", elemento.Descricao);
                cmd.Parameters.AddWithValue("@Responsavel", elemento.Responsavel);
                cmd.Parameters.AddWithValue("@Valor", elemento.Valor);
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
                cmd.CommandText = "SELECT * FROM TBEventos";
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
