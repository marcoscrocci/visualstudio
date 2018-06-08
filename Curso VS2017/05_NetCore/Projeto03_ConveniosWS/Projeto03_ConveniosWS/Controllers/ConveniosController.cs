using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto03_ConveniosWS.Models;

namespace Projeto03_ConveniosWS.Controllers
{
    [Produces("application/json")]
    [Route("api/Convenios")]
    public class ConveniosController : Controller
    {
        public IEnumerable<Convenio> GetConvenio()
        {
            return new List<Convenio>()
            {
                new Convenio() { Codigo = 10, Descricao = "Amil" },
                new Convenio() { Codigo = 20, Descricao = "Notredame" },
                new Convenio() { Codigo = 30, Descricao = "Sul America" },
                new Convenio() { Codigo = 30, Descricao = "Bradesco" },
                new Convenio() { Codigo = 30, Descricao = "Unimed" }
            };

        }
    }
}