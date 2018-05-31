function exibirDados() {
    var cnpj = document.getElementById("cnpj").value;
    var nome = document.getElementById("nome").value;
    var email = document.getElementById("email").value;

    // Vamos formar uma nova string contendo o resultado a ser apresentado para o usuário
    var mensagem = "CNPJ: " + cnpj +
        "\nNome: " + nome +
        "\nEmail: " + email;

    // Exibindo a mensagem na tela
    alert(mensagem);
}

// Registramos o evento click do botão "btnEnviar2" para executar a função exibirDados
var botao = document.getElementById("btnEnviar2");
botao.addEventListener("click", exibirDados);


document.getElementById("btnEnviar3")
    .addEventListener("click", function () {
        alert("Usando função anônima");
    });

document.getElementById("btnEnviar4")
    .addEventListener("click", () => {
        alert("Usando arrow function");
    });

