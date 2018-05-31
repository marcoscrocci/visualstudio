using Projeto01_ConsoleApp.Models;
using System;

namespace Projeto02_Aplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            CursoContext context = new CursoContext();
            DbInitializer.Initializer(context);

            Console.WriteLine("Pressione uma tecla...");
            Console.ReadKey();

            // Adicionar cursos no banco de dados
            Curso curso = new Curso();
            curso.Descricao = "Javascript";
            curso.CargaHoraria = 60;

            context.Add<Curso>(curso);
            context.SaveChanges();

            Console.WriteLine("Curso incluído com sucesso");
            Console.ReadKey();

        }
    }
}
