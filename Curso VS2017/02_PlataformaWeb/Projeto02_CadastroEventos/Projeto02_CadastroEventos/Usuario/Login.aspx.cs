using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto02_CadastroEventos.Usuario
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void confirmarButton_Click(object sender, EventArgs e)
        {
            string nome = Nome.Text;
            string senha = Senha.Text;

            var usuarioStore = new UserStore<IdentityUser>();
            var usuarioGerenciador =
            new UserManager<IdentityUser>(usuarioStore);
            var usuario = usuarioGerenciador.Find(nome, senha);
            if (usuario != null)
            {
                var gerenciadorDeAutenticacao = HttpContext.Current.GetOwinContext().Authentication;
                var identidade = usuarioGerenciador.CreateIdentity(usuario, 
                    DefaultAuthenticationTypes.ApplicationCookie);
                gerenciadorDeAutenticacao.SignIn(new AuthenticationProperties() {
                    IsPersistent = false
                }, identidade);

                string url = Request.QueryString["ReturnUrl"];
                if (!string.IsNullOrEmpty(url))
                {
                    Response.Redirect(url);
                }

                Response.Redirect("~/Menu.aspx");
            }
            else
            {
                mensagemErro.Text = "Usuario ou senha invalida.";
            }
        }
    }
}