<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutMaster.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Projeto02_CadastroEventos.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Selecione uma opção</h2>
        <ol>
            <li>
                <asp:HyperLink ID="cadEventosHyperLink" runat="server" NavigateUrl="~/CadEventos">Cadastro de Eventos</asp:HyperLink>
            </li>
            <li>
                <asp:HyperLink ID="cadConvidadosHyperLink" runat="server" NavigateUrl="~/CadConvidados">Cadastro de Convidados</asp:HyperLink>
            </li>
            <li>
                <asp:HyperLink ID="listaConvidadosHyperLink" runat="server" NavigateUrl="~/ListaConvidados">Listar Convidados por Evento</asp:HyperLink>
            </li>
            <li>
                <asp:HyperLink ID="listaConvidadosAjaxHyperLink" runat="server" NavigateUrl="~/ListaConvidadosAjax">Listar Convidados por Evento (Ajax)</asp:HyperLink>
            </li>
        </ol>
        
    </div>
</asp:Content>
