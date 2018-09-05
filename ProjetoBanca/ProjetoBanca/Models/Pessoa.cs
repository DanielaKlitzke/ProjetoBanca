using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }
        public String Nome { get; set; }
        public String CpfOuCnpj { get; set; }
        public String Rg { get; set; }
        public String Sexo { get; set; }
        public String Endereco { get; set; }
        public String Bairro { get; set; }
        public int NumeroResidencial { get; set; }
        public String Complemento { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String Cep { get; set; }
        public int Telefone { get; set; }
        //public String DataNascimento { get; set; }
        public String Email { get; set; }
        public String TipoPessoa { get; set; }
        //public Usuario IdUsuario { get; set; }
    }
}
