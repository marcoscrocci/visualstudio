<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projeto02_CadastroEventos.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Css/Estilos.css" rel="stylesheet" />    
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="borda-externa">
            <h1>Validação de Usuários</h1>
            <div class="borda-form">
                <asp:Label ID="Label1" runat="server" Text="Usuário:"></asp:Label>
                <br />
                <asp:TextBox ID="usuarioTextBox" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Senha:"></asp:Label>
                <br />
                <asp:TextBox ID="senhaTextBox" TextMode="Password" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="validarButton" runat="server" Text="Validar" />
            </div>
        </div>
    </form>
</body>
</html>
