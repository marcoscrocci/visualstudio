using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto01_ConsoleApp.Models
{
    public static class DbInitializer
    {
        public static void Initializer(CursoContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
