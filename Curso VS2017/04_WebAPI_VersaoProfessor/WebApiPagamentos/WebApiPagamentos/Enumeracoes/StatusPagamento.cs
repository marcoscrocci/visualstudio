using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiPagamentos.Enumeracoes
{
    public enum StatusPagamento
    {
        PAGTO_OK, //tudo ok, pagamento efetuado na aplicação
        PAGTO_EFETUADO, //o pagamento já foi realizado
        CARTAO_INEXISTENTE, //cartão não cadastrado
        SALDO_INDISPONIVEL, //limite inferior ao valor
    }
}