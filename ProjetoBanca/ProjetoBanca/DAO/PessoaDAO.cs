using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.DAO
{
    public class PessoaDAO
    {
        public void AdicionarNovaPessoa(Pessoa pessoa)
        {
            using (var contexto = new PetContext())
            {
                contexto.Pessoas.Add(pessoa);
                contexto.SaveChanges();
            }
        }
    }
}