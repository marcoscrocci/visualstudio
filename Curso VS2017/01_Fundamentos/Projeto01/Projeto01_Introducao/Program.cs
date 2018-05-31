using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01_Introducao
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Introdução ao Visual Studio 2017
             * Aplicação Console
             */
            // Método: tudo que executa uma tarefa
            // Instrução: conjunto de tarefas previamente definidas
            Console.WriteLine("Curso Desenvolvimento Web");
            Console.WriteLine("Impacta");
            Console.Write("Período: ");
            //Console.Write("23/04 a 04/06");

            // Declaração de Variáveis
            string curso = "Desenvolvimento Web";
            int quantidade = 25;
            Int32 cargaHoraria = 100;
            string periodo = "N";

            Console.WriteLine("Curso: " + curso);
            Console.WriteLine("Período: " + periodo);
            Console.WriteLine("Quant. alunos: " + quantidade);
            Console.WriteLine("Carga Horária: " + cargaHoraria);


            Console.ReadKey();
        }
    }
}
