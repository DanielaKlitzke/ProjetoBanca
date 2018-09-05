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
        public String TipoCategoria { get; set; }
    }
}