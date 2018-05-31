<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UsuarioUC.ascx.cs" Inherits="Projeto02_CadastroEventos.UsuarioUC" %>
<%-- WebControl LoginView --%>
<asp:LoginView runat="server" ViewStateMode="Disabled">
    <%-- Modelo para usuário não autenticado --%>
    <AnonymousTemplate>
        <ul class="nav navbar-nav navbar-right">
            <li>
                <a runat="server" href="~/Usuario/Criar">Cadastrar-se</a></li>
            <li>
                <a runat="server" href="~/Usuario/Login">Log in</a></li>
        </ul>
    </AnonymousTemplate>
    <%-- Modelo para usuário autenticado --%>
    <LoggedInTemplate>
        <ul class="nav navbar-nav navbar-right">
            <li>
                <a href="#"><%: Page.User.Identity.Name %></a>
            </li>
            <li>
                <asp:LoginStatus
                    runat="server"
                    LogoutAction="Redirect"
                    LogoutText="Log off"
                    LogoutPageUrl="~/usuario/logout.aspx" />
            </li>
        </ul>
    </LoggedInTemplate>
</asp:LoginView>
