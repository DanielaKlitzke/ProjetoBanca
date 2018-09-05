using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Produtos
    {
        [Key]
        public int IdProduto { get; set; }
        public int CodigoProduto { get; set; }
        public String NomeProduto { get; set; }
        public double ValorProduto { get; set; }
        public String DescricaoProduto { get; set; }
        public UnidadeMedida IdUnidadeMedida { get; set; }
        public double Medida { get; set; }
        public Categoria IdCategoria { get; set; }
        public int AtivoNaoAtivo { get; set; }
    }
}