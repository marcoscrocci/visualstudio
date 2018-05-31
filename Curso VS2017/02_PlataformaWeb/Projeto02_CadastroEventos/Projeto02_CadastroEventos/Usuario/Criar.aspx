<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutMaster.Master" AutoEventWireup="true" CodeBehind="Criar.aspx.cs" Inherits="Projeto02_CadastroEventos.Usuario.Criar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- Título --%>
    <h2>Novo Registro de Usuário</h2>
    <hr />

    <%-- Mensagem --%>
    <p class="text-danger">
    <asp:Literal runat="server" ID="mensagemErro" />
    </p>

    <%-- Formulário --%>
    <div class="form-horizontal">
        <%-- Nome --%>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Nome" 
                CssClass="col-md-2 control-label">Nome</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Nome" CssClass="form-control" />
                <%--<asp:RequiredFieldValidator runat="server" ControlToValidate="Nome"
                    CssClass="text-danger" ErrorMessage="Nome é obrigatório." />--%>
            </div>
        </div>

        <%-- senha --%>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Senha" 
                CssClass="col-md-2 control-label">Senha</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Senha" TextMode="Password" CssClass="form-control" />
                <%--<asp:RequiredFieldValidator runat="server" ControlToValidate="Senha"
                    CssClass="text-danger" ErrorMessage="Senha é obrigatório." />--%>
            </div>
        </div>

        <%-- Confirmar Senha --%>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ConfirmarSenha"
                CssClass="col-md-2 control-label">Confirmar Senha</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ConfirmarSenha" TextMode="Password"
                    CssClass="form-control" />
                <%--<asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmarSenha"
                    CssClass="text-danger" Display="Dynamic" 
                    ErrorMessage="Confirmação de senha é obrigatório." />
                <asp:CompareValidator runat="server" ControlToCompare="Senha"
                    ControlToValidate="ConfirmarSenha" CssClass="text-danger"
                    Display="Dynamic" ErrorMessage="A senha e a confirmação estão diferentes." />--%>
            </div>
        </div>
        
        <%-- Confirmar --%>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" ID="confirmarButton" 
                    Text="Confirmar" CssClass="btn btn-default" OnClick="confirmarButton_Click" />
            </div>
        </div>
    </div>
</asp:Content>
