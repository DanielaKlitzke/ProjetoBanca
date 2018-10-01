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
        [Required, StringLength(20)]
        public String CodigoProduto { get; set; }
        [Required, StringLength(50)]
        public String NomeProduto { get; set; }
        [Required]
        public double ValorProduto { get; set; }
        [Required, StringLength(100)]
        public String DescricaoProduto { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public int IdUnidadeMedida { get; set; }
        [Required]
        public double Medida { get; set; }
        public Categoria Categoria { get; set; }
        public int IdCategoria { get; set; }
        public int AtivoNaoAtivo { get; set; }
    }
}