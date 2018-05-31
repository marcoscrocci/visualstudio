using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02_Metodos.Classes
{
    public class Utilitarios
    {
        public static int ContarCaracteres(string texto)
        {
            return RemoverEspacos(texto).Length;
        }

        public static string RemoverEspacos(string texto)
        {
            return texto.Replace(" ", "");
        }

    }
}
