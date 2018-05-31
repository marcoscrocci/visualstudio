using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto02_AspNetCore.Models
{
    public static class Utils
    {
        // Método para obter a extensão de uma imagem
        public static string GetExtension(this IFormFile file)
        {
            return Path.GetExtension(file.FileName);
        }
        
        public static byte[] ToByteArray(this IFormFile file)
        {
            using(BinaryReader reader = new BinaryReader(file.OpenReadStream()))
            {
                return reader.ReadBytes((int)file.Length);
            }
        }

    }
}
