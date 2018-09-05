using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public String Login { get; set; }
        public String Senha { get; set; }
        public int Permissao { get; set; }
    }
}