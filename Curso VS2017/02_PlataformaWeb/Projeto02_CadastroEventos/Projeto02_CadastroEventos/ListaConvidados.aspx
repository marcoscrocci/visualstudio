<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutMaster.Master" AutoEventWireup="true" CodeBehind="ListaConvidados.aspx.cs" Inherits="Projeto02_CadastroEventos.ListaConvidados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-4">                
                <h3>Dados do Convidado</h3>
                <hr />
                <div>  <%--class="form-row"--%>
                    <div class="form-group row">
                        <asp:Label ID="eventoLabel" runat="server" Text="Evento:" CssClass="col-md-3"></asp:Label>
                        <div class="col-md-9">
                            <asp:DropDownList ID="eventoDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                    </div>
                    <asp:Button ID="listarButton" runat="server" Text="Listar Convidados" CssClass="btn btn-primary" OnClick="listarButton_Click" />
                    <br />
                    <br />
                    <div class="form-group row">
                        <asp:Label ID="mensagemLabel" runat="server"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-md-8">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Repeater ID="convidadoRepeater" runat="server">
                            <HeaderTemplate>
                                <table class="table table-striped">
                                    <tr>
                                        <th>Evento</th>
                                        <th>Convidado</th>
                                        <th>Email</th>                                
                                    </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <asp:Label ID="eventoLabel" runat="server" Text='<%# Eval("Evento") %>'></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="convidadoLabel" runat="server" Text='<%# Eval("Nome") %>'></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="emailLabel" runat="server" Text='<%# Eval("Email") %>'></asp:Label>
                                    </td>
                                </tr>
                            </ItemTemplate>                    
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="listarButton" EventName="Click" />
                    </Triggers>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>

</asp:Content>
