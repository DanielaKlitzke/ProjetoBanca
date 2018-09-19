using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.DAO
{
    public class PessoaDAO
    {
        public void Adicionar(Pessoa pessoa)
        {
            using (var contexto = new PetContext())
            {
                contexto.Pessoas.Add(pessoa);
                contexto.SaveChanges();
            }
        }

        public IList<Pessoa> ListarPessoa()
        {
            using (var contexto = new PetContext())
            {
                return contexto.Pessoas.ToList();
            }
        }

        public Pessoa BuscaPorId(int id)
        {
            using (var contexto = new PetContext())
            {
                return contexto.Pessoas.Find(id);
            }
        }

        public Pessoa Busca(string login, string senha)
        {
            using (var contexto = new PetContext())
            {
                return contexto.Pessoas.FirstOrDefault(u => u.CpfOuCnpj == login && u.Senha == senha);
            }
        }

        public void ExcluirPessoa(Pessoa pessoa)
        {
            using (var contexto = new PetContext())
            {
                contexto.Pessoas.Remove(pessoa);
                contexto.SaveChanges();
            }
        }

        public void AtualizarPessoa(Pessoa pessoa)
        {
            using (var contexto = new PetContext())
            {
                contexto.Pessoas.Update(pessoa);
                contexto.SaveChanges();
            }
        }
    }
}