using Projeto01_IntroducaoWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Projeto01_IntroducaoWebAPI.Controllers
{
    public class HomeController : ApiController
    {

        #region Coleções

        public List<string> nomes = new List<string>()
        {
            "Odete", "Pradilina", "Anesia", "Bernardson"
        };

        public List<Produto> produtos = new List<Produto>()
        {
            new Produto()
            {
                Codigo = 10,
                Descricao = "Mouse",
                Preco = 30,
                CategoriaInfo = new Categoria()
                {
                    Id = 100,
                    Nome = "Informática"
                }
            },
            new Produto()
            {
                Codigo = 20,
                Descricao = "Bicicleta",
                Preco = 500,
                CategoriaInfo = new Categoria()
                {
                    Id = 100,
                    Nome = "Veiculo"
                }
            }
        };

        #endregion Coleções

        #region Metodos HTTP

        // HTTP GET (unica forma de acesso via URL direta)
        /*[Route("ListaNomes")]*/
        // api/home
        public List<string> GetNomes()
        {
            return nomes;
        }

        // ListaProdutos
        [Route("ListaProdutos")]
        public List<Produto> GetProdutos()
        {
            return produtos;
        }

        // TodosProdutos
        [HttpGet]
        [Route("TodosProdutos")]
        public List<Produto> BuscarProdutos()
        {
            return produtos;
        }

        // Retornar um produto pelo Codigo
        public Produto GetProduto(int id)
        {
            return produtos.Find(p => p.Codigo == id);
        }

        [Route("PrimeiroNome/{id}")]
        public string GetNome(string id)
        {
            return nomes.Find(p => p.Contains(id));
        }

        [Route("AlgunsNomes/{id}")]
        public List<string> GetNomes(string id)
        {
            return nomes.Where(p => p.ToLower().Contains(id.ToLower())).ToList<string>();
        }

        #endregion Metodos HTTP

    }
}
