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

        public Pessoa BuscaSenha(string login, string senha, int permissao)
        {
            using (var contexto = new PetContext())
            {
                return contexto.Pessoas.FirstOrDefault(u => u.CpfOuCnpj == login && u.Senha == senha && u.Permissao == permissao);
            }
        }

        public Pessoa BuscaPorCpfOuCnpj(string cpfCnpj)
        {
            using (var contexto = new PetContext())
            {
                return contexto.Pessoas.FirstOrDefault(u => u.CpfOuCnpj == cpfCnpj);
            }
        }

        public Pessoa BuscaPorPermissao(int permissao)
        {
            using (var contexto = new PetContext())
            {
                return contexto.Pessoas.FirstOrDefault(u => u.Permissao == permissao);
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