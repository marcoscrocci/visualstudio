using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto02_EventosMVC
{
    /*
     *  string cidade = "";
     *  string s = cidade.VerificarConteudo();
    */
    public static class MetodosDeExtensao
    {
        public static string VerificarConteudo(this string texto)
        {
            if (texto.Trim().Length == 0)
            {
                throw new Exception("O texto não pode ser vazio");
            }
            return texto;
        }

        public static string RetirarAcentos(this string texto)
        {
            string com_Acentos =
                "ÄÀÁÂÃäàáâãËÈÉÊëèéêÏÌÍÎïìíîÖÒÓÔÕöòóôõÜÙÚÛüùúûÇçÑñ";
            string sem_Acentos =
                "AAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUUuuuuCcNn";

            for (int i = 0; i < com_Acentos.Length; i++)
            {
                texto = texto.Replace(com_Acentos[i], sem_Acentos[i]);
            }
            return texto;
        }

        public static int ToInt(this string string_numero)
        {
            try
            {
                return int.Parse(string_numero);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

    }




}