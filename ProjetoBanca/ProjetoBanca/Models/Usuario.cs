using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String CpfOuCnpj { get; set; }
        public String Rg { get; set; }
        public String Sexo { get; set; }
        public String Endereco { get; set; }
        public String Bairro { get; set; }
        public int NumeroResidencia { get; set; }
        public String Complemento { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String Cep { get; set; }
        public int Telefone { get; set; }
        public String DataNascimento { get; set; }
        public String TipoPessoa { get; set; }
        public String Senha { get; set; }
        public String Email { get; set; }
    }
}
