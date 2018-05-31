$(document).ready(function () {

    var cursos = ["Java", "SQL Server", "ASP.NET", "PHP"];

    // Instrução para preencher o elemento <select> com estes cursos
    $.each(cursos, function (i, item) {
        $("#lista").append($("<option>", {
            value: i, 
            text: item
        }));
    });

    $("#btnEnviar").click(function () {
        // Obtendo o conteúdo dos campos de entrada.
        var nome = $("#nome").val();
        var curso = $("#lista").val();
        var idade = $("#idade").val();

        // Definir a variável para armazenar a resposta
        var resultado;

        // Verificamos se o elemento div possui alguma classe css. Se possuir, nós a removemos
        if ($("#resposta").hasClass("erro")) {
            $("#resposta").removeClass("erro");
        }
        if ($("#resposta").hasClass("ok")) {
            $("#resposta").removeClass("ok");
        }

        if (idade == "") {
            resultado = "Idade inválida";
            $("#resposta").addClass("erro");
        }
        else
        {
            if (idade < 18) {
                resultado = "Menor de idade";
            } else {
                resultado = "Maior de idade";
            }
            $("#resposta").addClass("ok");
        }

        $("#resposta").hide();
        $("#resposta").html(resultado);
        $("#resposta").fadeIn(3000);
        $("#resposta").fadeOut(3000);
    });

});