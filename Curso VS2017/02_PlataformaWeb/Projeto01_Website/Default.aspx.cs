using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cursoDropDownList.Items.Add("Geografia");
            cursoDropDownList.Items.Add("Matemática");
            cursoDropDownList.Items.Add("Química");
        }
    }

    protected void enviarButton_Click(object sender, EventArgs e)
    {
        string nome = nomeTextBox.Text;
        string email = emailTextBox.Text;
        string curso = cursoDropDownList.Text;

        string resposta = string
            .Format("<b>Nome:</b> {0}, <b>Email:</b> {1}, <b>Curso:</b> {2}",
            nome, email, curso);
        //Response.Write(resposta);
        
        respostaLabel.Text = resposta;
    }

    protected void cursoDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        int posicao = cursoDropDownList.SelectedIndex;
        switch (posicao)
        {
            case 0: chLabel.Text = "40 horas"; break;
            case 1: chLabel.Text = "300 horas"; break;
            case 2: chLabel.Text = "10 horas"; break;
            default: chLabel.Text = ""; break;
        }
    }
}