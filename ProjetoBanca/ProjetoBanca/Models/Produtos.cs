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

        [Required,]
        public int CodigoProduto { get; set; }
        public String NomeProduto { get; set; }
        public double ValorProduto { get; set; }
        public String DescricaoProduto { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public int IdUnidadeMedida { get; set; }
        public double Medida { get; set; }
        public Categoria Categoria { get; set; }
        public int IdCategoria { get; set; }
        public int AtivoNaoAtivo { get; set; }
    }
}