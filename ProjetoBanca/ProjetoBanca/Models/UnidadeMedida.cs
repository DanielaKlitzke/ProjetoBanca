using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class UnidadeMedida
    {
        [Key]
        public int IdUnidadeMedida { get; set; }

        [Required, StringLength(20)]
        public String TipoUnidadeMedida { get; set; }
    }
}