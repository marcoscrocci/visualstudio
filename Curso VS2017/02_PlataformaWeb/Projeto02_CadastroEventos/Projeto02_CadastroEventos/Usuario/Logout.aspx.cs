using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto02_CadastroEventos.Usuario
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var gerenciadorDeAutenticacao = HttpContext.Current.GetOwinContext().Authentication;
            gerenciadorDeAutenticacao.SignOut();
            Response.Redirect("~/Menu.aspx");
        }
    }
}