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
                Descricao="Mouse",
                Preco = 30,
                CategoriaInfo = new Categoria()
                {
                    Id = 100, Nome = "Informatica"
                }
            },
            new Produto()
            {
                Codigo = 20,
                Descricao="Bicicleta",
                Preco = 500,
                CategoriaInfo = new Categoria()
                {
                    Id = 200, Nome = "Veiculo"
                }
            }
        };
        #endregion

        #region Metodos HTTP
        //HTTP GET(unica forma de acesso via URL direta)

        // api/home
        public List<string> GetNomes()
        {
            return nomes;
        }

        // /listaProdutos
        [Route("listaProdutos")]
        public List<Produto> GetProdutos()
        {
            return produtos;
        }

        // /todosProdutos
        [HttpGet]
        [Route("todosProdutos")]
        public List<Produto> BuscarProdutos()
        {
            return produtos;
        }

        //retornar um produto pelo id
        public Produto GetProduto(int id)
        {
            return produtos.Find(p => p.Codigo == id);
        }

        [Route("primeiroNome/{id}")]
        public string GetNome(string id)
        {
            return nomes.Find(p => p.Contains(id));
        }

        [Route("algunsNomes/{id}")]
        public List<string> GetNomes(string id)
        {
            return nomes
                .Where(p => p.ToLower().Contains(id.ToLower()))
                .ToList<string>();
        }
    #endregion


    }
}
