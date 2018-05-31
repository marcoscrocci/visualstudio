using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03_BibliotecaClasses
{
    public class Metodos
    {
        public static int MaiorNumero(int n1, int n2)
        {
            if (n1 > n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }

        public static int MaiorNumero(int[] numeros)
        {
            if (numeros.Length == 0)
            {
                return 0;
            }
            else
            {
                int maior = numeros[0];
                for (int i = 1; i < numeros.Length; i++)
                {
                    if (numeros[i] > maior)
                    {
                        maior = numeros[i];
                    }
                }
                return maior;
            }
            
        }
    }
}
