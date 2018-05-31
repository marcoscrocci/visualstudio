<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Projeto02_CadastroEventos.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro de Eventos e Convidados</title>
    <link href="Css/Estilos.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container alert-heading margem-superior">
            <h1>Bem vindo à nossa página de agenda de eventos</h1>
            <asp:HyperLink ID="loginHyperLink" runat="server" NavigateUrl="~/Usuario/Login">Acesso Restrito</asp:HyperLink>
        </div>
        <hr />
        <div class="container">
            <section>
                <h2>Cursos oferecidos pela empresa</h2>
                <p>
                    Nossa empresa oferece cursos na área de T.I.,
                    nas seguintes modalidades:
                </p>
                <ul>
                    <li>Presencial</li>
                    <li>Online</li>
                    <li><i>In-company</i></li>
                </ul>
            </section>
            <div class="row">
                <div class="col-md-4">
                    <h3>Presencial</h3>
                    <img src="Imagens/curso-presencial.jpg" class="img-thumbnail" />
                </div>
                <div class="col-md-4">
                    <h3>Online</h3>
                    <img src="Imagens/curso-online.jpg" class="img-thumbnail" />
                </div>
                <div class="col-md-4">
                    <h3>In-company</h3>
                    <img src="Imagens/curso-incompany.jpg" class="img-thumbnail" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
