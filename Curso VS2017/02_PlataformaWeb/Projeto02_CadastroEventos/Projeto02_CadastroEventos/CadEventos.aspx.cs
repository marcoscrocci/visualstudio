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
    public partial class CadEventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindRepeater();
            if (!IsPostBack)
            {
                dataTextBox.Focus();
            }
        }

        protected void enviarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Evento evento = new Evento();
                evento.Data = Convert.ToDateTime(dataTextBox.Text);
                evento.Descricao = descricaoTextBox.Text;
                evento.Responsavel = responsavelTextBox.Text;
                evento.Valor = Convert.ToDouble(valorTextBox.Text);

                EventosDao dao = Repositorio.GetEventosDao();                
                dao.Incluir(evento);                
                BindRepeater();
                mensagemLabel.CssClass = "col-md-12 alert alert-success";
                mensagemLabel.Text = "Evento incluído com sucesso!";
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
            dataTextBox.Text = "";
            descricaoTextBox.Text = "";
            responsavelTextBox.Text = "";
            valorTextBox.Text = "";
        }

        private void BindRepeater()
        {
            EventosDao dao = Repositorio.GetEventosDao();
            eventosRepeater.DataSource = dao.Listar();
            eventosRepeater.DataBind();            
        }

    }
}