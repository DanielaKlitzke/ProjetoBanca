using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public String Login { get; set; }
        public String Senha { get; set; }
    }
}