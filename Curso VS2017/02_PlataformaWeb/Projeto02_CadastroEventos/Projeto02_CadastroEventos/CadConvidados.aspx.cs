using AcessoDados.Data;
using AcessoDados.Models;
using Projeto02_CadastroEventos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto02_CadastroEventos
{
    public partial class CadConvidados : System.Web.UI.Page
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
                BindRepeater();
            }

            

        }

        protected void enviarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Convidado convidado = new Convidado();
                convidado.IdEvento = int.Parse(eventoDropDownList.SelectedValue);
                convidado.Nome = nomeTextBox.Text;
                convidado.Email = emailTextBox.Text;
                //convidado.InfoEvento = Repositorio.GetEventosDao().Buscar(convidado.IdEvento);

                ConvidadosDao dao = Repositorio.GetConvidadosDao();
                dao.Incluir(convidado);

                BindRepeater();
                mensagemLabel.CssClass = "col-md-12 alert alert-success";
                mensagemLabel.Text = "Convidado incluído com sucesso!";
                LimparCampos();
            }
            catch (Exception ex)
            {
                mensagemLabel.CssClass = "col-md-12 alert alert-danger";
                mensagemLabel.Text = ex.Message;
            }
        }

        private void LimparCampos()
        {
            //eventoDropDownList.Text = "";
            nomeTextBox.Text = "";
            emailTextBox.Text = "";
        }


        private void BindRepeater()
        {
            ConvidadosDao dao = Repositorio.GetConvidadosDao();
            convidadoRepeater.DataSource = dao.Listar();
            convidadoRepeater.DataBind();
        }

    }
}