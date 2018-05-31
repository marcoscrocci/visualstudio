﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto01_IntroducaoWebAPI.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public Categoria CategoriaInfo { get; set; }
    }
}