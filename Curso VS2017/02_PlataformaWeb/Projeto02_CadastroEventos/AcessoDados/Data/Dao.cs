using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Data
{
    public abstract class Dao<T>
    {
        //Componentes de Acesso a Dados
        protected SqlConnection cn;
        protected SqlCommand cmd;
        protected SqlDataAdapter adapter;

        //string de conexão
        private string conexao = "Persist Security Info=False;User ID=sa;Password=Imp@ct@;Initial Catalog=DBEVENTOS;Data Source=.";

        //construtor
        public Dao()
        {
            cn = new SqlConnection(conexao);
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            adapter = new SqlDataAdapter();            
        }

        //método para abrir a conexão
        protected void AbrirConexao()
        {
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //método para fechar a conexão
        protected void FecharConexao()
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }

        public abstract void Incluir(T elemento);

        public abstract T Buscar(int id);

        public abstract DataTable Listar(int id = -1);


    }
}
