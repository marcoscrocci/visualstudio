using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04_AppClientes.Classes
{
    /*
     *   Construtores:
     *   1. Deve ter o mesmo nome da classe
     *   2. Não possui tipo de retorno definido
     *   3. Toda classe possui um construtor
     *   4. Se nenhum construtor for adicionado, o compilador 
     *      inclui o costrutor padrão (sem parâmetros)
     *   5. O objetivo do construtor padrão é gerar os elementos 
     *      do objeto, com valores default:
     *      - Variáveis numéricas: 0
     *      - Variáveis booleandas: false
     *      - Referências: null
     *   6. A partir do momento que um construtor for adicionado à 
     *      classe, este será usado, e o compilador não coloca mais
     *      o dele.
     *   7. Os construtores, assim como os métodos, podem ser 
     *      sobrecarregados.
     *   8. Para que o objeto de uma subclasse seja criado, primeiro
     *      é executado o construtor da superclasse e só depois o 
     *      da subclasse.
     */

    public abstract class Cliente
    {
        public abstract string NumeroDocumento { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<Automovel> Automoveis { get; set; }

        public Cliente()
        {
            this.Automoveis = new List<Automovel>();
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
