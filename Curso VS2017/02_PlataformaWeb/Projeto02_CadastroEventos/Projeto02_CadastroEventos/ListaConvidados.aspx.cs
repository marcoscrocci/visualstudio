using AcessoDados.Data;
using Projeto02_CadastroEventos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto02_CadastroEventos
{
    public partial class ListaConvidados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EventosDao dao = Repositorio.GetEventosDao();
                eventoDropDownList.DataSource = dao.Listar();
                eventoDropDownList.DataTextField = "Descricao";
                eventoDropDownList.DataValueField = "Id";
                eventoDropDownList.DataBind();

                eventoDropDownList.Focus();
                //BindRepeater();
            }

        }

        private void BindRepeater(int id)
        {
            ConvidadosDao dao = Repositorio.GetConvidadosDao();
            convidadoRepeater.DataSource = dao.Listar(id);
            convidadoRepeater.DataBind();
        }

        protected void listarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int idEvento = int.Parse(eventoDropDownList.SelectedValue);
                BindRepeater(idEvento);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}