using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiroWeb.Models
{
    public static class DbInitializer
    {
        public static void Initialize(ControleFinanceiroDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
