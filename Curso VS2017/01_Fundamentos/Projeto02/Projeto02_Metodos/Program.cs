using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02_Metodos.Classes;
using Projeto03_BibliotecaClasses;

namespace Projeto02_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 02");
            Console.WriteLine("Informe seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nome informado: " + nome);
            Console.WriteLine("Idade informada: " + idade);


            string curso = "Visual Studio 2017";
            Console.WriteLine(Utilitarios.ContarCaracteres(curso));

            // Declarando um array de inteiros
            int[] numeros = {3, 8, 7, 4, 9, 5, 2};
            int numeroMaior = Metodos.MaiorNumero(numeros);
            Console.WriteLine("Maior número: " + numeroMaior);
            
            Console.ReadKey();
        }


    }
}
