using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Estoque
    {
        [Key]
        public int IdEstoque { get; set; }
        public Produtos IdProduto { get; set; }
        public double QTD { get; set; }
    }
}