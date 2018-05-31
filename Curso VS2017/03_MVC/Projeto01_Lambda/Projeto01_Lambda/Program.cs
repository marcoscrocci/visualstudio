using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01_Lambda
{
    public delegate int Calculo(int x, int y);
    public delegate string Resposta(int x, string s);
    public delegate string Verificacao<T>(T elemento);

    class Program
    {
        static void Main(string[] args)
        {
            Calculo c1 = (x, y) => x + y;
            int soma = c1(10, 12);
            Console.WriteLine(soma);

            Resposta resp = (p1, p2) => p2.Substring(0, p1);
            Console.WriteLine(resp(5, "Desenvolvimento Web"));

            Resposta resp2 = (p1, p2) =>
            {
                string texto = "";
                for (int i = 0; i < p1; i++)
                {
                    texto += p2;
                }
                return texto;
            };
            Console.WriteLine(resp2(4, "Emilio"));

            Verificacao<DateTime> v1 = p => p.ToLongDateString();
            Console.WriteLine(v1(DateTime.Now));

            //Aplicação: Lista de Nomes
            List<string> nomes = new List<string>()
            {
                "Renata", "Vanessa", "Sandra", "Bruna"
            };

            string busca = nomes.Find(p => p.StartsWith("V"));
            Console.Write(busca);

            Console.ReadKey();
        }

        //static int Calcular(int x, int y)
        //{

        //}

    }
}
