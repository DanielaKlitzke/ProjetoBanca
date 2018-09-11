using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        [Required, StringLength(20)]
        public String TipoCategoria { get; set; }
    }
}