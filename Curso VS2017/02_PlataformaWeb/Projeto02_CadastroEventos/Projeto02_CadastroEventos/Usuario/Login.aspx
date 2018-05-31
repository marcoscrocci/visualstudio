<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projeto02_CadastroEventos.Usuario.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- Título --%>
    <h2>Login</h2>
    <hr />
    <%-- Formulário --%>
    <div class="form-horizontal">
        <%-- Mensagem --%>
        <p class="text-danger">
            <asp:Literal runat="server" ID="mensagemErro" />
        </p>
        <%-- Nome --%>
        <div class="form-group">
            <asp:Label
                runat="server"
                AssociatedControlID="Nome"
                CssClass="col-md-2 control-label">Nome</asp:Label>
            <div class="col-md-10">
                <asp:TextBox
                    runat="server"
                    ID="Nome"
                    CssClass="form-control" />
                <%--<asp:RequiredFieldValidator
                    runat="server"
                    ControlToValidate="Nome"
                    CssClass="text-danger"
                    ErrorMessage="Nome é obrigatório." />--%>
            </div>
        </div>
        <%-- senha --%>
        <div class="form-group">
            <asp:Label
                runat="server"
                AssociatedControlID="Senha"
                CssClass="col-md-2 control-label">Senha</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server"
                    ID="Senha"
                    TextMode="Password"
                    CssClass="form-control" />
                <%--<asp:RequiredFieldValidator
                    runat="server"
                    ControlToValidate="Senha"
                    CssClass="text-danger"
                    ErrorMessage="Senha é obrigartório." />--%>
            </div>
        </div>
        <%-- Gravar --%>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button
                    runat="server"
                    ID="confirmarButton"
                    Text="Confirmar"
                    CssClass="btn btn-default" OnClick="confirmarButton_Click" />
            </div>
        </div>
    </div>
</asp:Content>
