<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutMaster.Master" AutoEventWireup="true" CodeBehind="CadEventos.aspx.cs" Inherits="Projeto02_CadastroEventos.CadEventos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-4">                
                <h3>Dados do Evento</h3>
                <hr />
                <div>  <%--class="form-row"--%>
                    <div class="form-group row">
                        <asp:Label ID="dataLabel" runat="server" Text="Data:" CssClass="col-md-3"></asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox ID="dataTextBox" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <asp:Label ID="descricaoLabel" runat="server" Text="Descrição:" CssClass="col-md-3"></asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox ID="descricaoTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <asp:Label ID="responsavelLabel" runat="server" Text="Responsável:" CssClass="col-md-3"></asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox ID="responsavelTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <asp:Label ID="valorLabel" runat="server" Text="Valor:" CssClass="col-md-3"></asp:Label>
                        <div class="col-md-9">
                            <asp:TextBox ID="valorTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>                    
                    <asp:Button ID="enviarButton" runat="server" Text="Enviar" CssClass="btn btn-primary" OnClick="enviarButton_Click" />
                    <br />
                    <br />
                    <div class="form-group row">
                        <asp:Label ID="mensagemLabel" runat="server"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-md-8">
                <asp:Repeater ID="eventosRepeater" runat="server">
                    <HeaderTemplate>
                        <table class="table table-striped">
                            <tr>
                                <th>Data</th>
                                <th>Descrição</th>
                                <th>Responsável</th>
                                <th class="text-right">Valor</th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                <asp:Label ID="dataLabel" runat="server" Text='<%# string.Format("{0:dd/MM/yyyy}", Eval("Data")) %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="descricaoLabel" runat="server" Text='<%# Eval("Descricao") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="responsavelLabel2" runat="server" Text='<%# Eval("Responsavel") %>'></asp:Label>
                            </td>
                            <td class="text-right">
                                <asp:Label ID="valorLabel" runat="server" Text='<%# string.Format("{0:c}", Eval("Valor")) %>'></asp:Label>
                            </td>
                        </tr>
                    </ItemTemplate>                    
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
