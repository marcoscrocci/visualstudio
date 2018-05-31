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
    public partial class Criar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void confirmarButton_Click(object sender, EventArgs e)
        {
            //Obter os Valores do TextBox
            string nome = Nome.Text;
            string senha = Senha.Text;
            //Obter a UserStore, UserManager
            var usuarioStore = new UserStore<IdentityUser>();
            var usuarioGerenciador =
            new UserManager<IdentityUser>(usuarioStore);
            //Criar uma identidade
            var usuarioInfo = new IdentityUser() { UserName = Nome.Text };
            //Gravar
            IdentityResult resultado =
            usuarioGerenciador.Create(usuarioInfo, Senha.Text);
            //Se ok,
            if (resultado.Succeeded)
            {
                //Autentica e volta para a página inicial
                var gerenciadorDeAutenticacao =
                HttpContext.Current.GetOwinContext().Authentication;
                var identidadeUsuario = usuarioGerenciador.CreateIdentity(
                usuarioInfo,
                DefaultAuthenticationTypes.ApplicationCookie);
                gerenciadorDeAutenticacao.SignIn(
                new AuthenticationProperties() { },
                identidadeUsuario);
                Response.Redirect("~/Menu.aspx");
            }
            else //Erro, exibe o erro
            {
                string erro = resultado.Errors.FirstOrDefault();
                mensagemErro.Text = erro;
            }
        }
    }
}