﻿using System;
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

        [Required, StringLength(20)]
        public String Nome { get; set; }

        //[Required]
        public String CpfOuCnpj { get; set; }

        //[Required, StringLength(7)]
        public String Rg { get; set; }

        //[Required]
        public String Sexo { get; set; }

        //[Required,StringLength(150)]
        public String Endereco { get; set; }

        //[Required, StringLength(80)]
        public String Bairro { get; set; }

        public int NumeroResidencial { get; set; }

        //[Required, StringLength(20)]
        public String Complemento { get; set; }

        //[Required, StringLength(100)]
        public String Cidade { get; set; }

        //[Required, StringLength(2)]
        public String Estado { get; set; }

        //[Required, StringLength(8)]
        public String Cep { get; set; }

        //[Required, StringLength(11)]
        public int Telefone { get; set; }

        public String DataNascimento { get; set; }

        //[Required, StringLength(100)]
        public String Email { get; set; }

        public String TipoPessoa { get; set; }
        //public Usuario IdUsuario { get; set; }
    }
}
