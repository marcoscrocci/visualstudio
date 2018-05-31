<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:Literal runat="server" ID="cabecalho" Text="Conceitos de Server Controls" />
            </h1>
            <%
                string curso = "Desenvolvimento Web";
                Response.Write("<b>" + curso + "</b><br/>");
            %>            
            <asp:Label runat="server" ID="emailLabel" Text="Seu email: " />
            <asp:TextBox runat="server" ID="emailTextBox" />
            <br />
            <asp:Label ID="nomeLabel" runat="server" Text="Seu nome: "></asp:Label>
            <asp:TextBox ID="nomeTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="seuCursoLabel" runat="server" Text="Seu curso: "></asp:Label>
            <asp:DropDownList ID="cursoDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cursoDropDownList_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Label ID="chLabel" runat="server"></asp:Label>
            <br />
            <asp:Button runat="server" 
                ID="enviarButton" 
                Text="Enviar"
                OnClick="enviarButton_Click"/>
            <br />
            <asp:Label ID="respostaLabel" runat="server"></asp:Label>
        </div>

    </form>
</body>
</html>
