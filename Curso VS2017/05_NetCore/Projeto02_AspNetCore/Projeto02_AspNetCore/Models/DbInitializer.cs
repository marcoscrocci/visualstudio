using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto02_AspNetCore.Models
{
    public static class DbInitializer
    {
        public static void Initialize(ClinicaContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
