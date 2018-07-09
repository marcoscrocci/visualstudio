using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LiveDemoAPIREST.Data;
using LiveDemoAPIREST.Models;

namespace LiveDemoAPIREST.Controllers
{
    [Route("api/[controller]")]
    public class CotacoesController : Controller
    {
        // GET api/values - Parâmetros: context (injeção de dependência) e o id (sigla da moeda).
        [HttpGet("{id}")]
        public Cotacao Get([FromServices]CotacoesContext context, string id)
        {
            return context.Cotacoes
                .Where(c => c.Sigla == id)
                .FirstOrDefault();
        }
        
    }
}
