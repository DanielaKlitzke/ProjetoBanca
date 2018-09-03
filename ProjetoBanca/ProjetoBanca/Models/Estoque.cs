using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Estoque
    {
        public int IdEstoque { get; set; }
        public Produtos IdProduto { get; set; }
        public double QTD { get; set; }
    }
}