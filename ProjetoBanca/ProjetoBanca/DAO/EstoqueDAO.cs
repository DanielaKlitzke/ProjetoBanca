using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.DAO
{
    public class EstoqueDAO
    {
        public void Adicionar(Estoque estoque)
        {
            using (var contexto = new PetContext())
            {
                contexto.Estoques.Add(estoque);
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

        public void ExcluirPessoa()
        {
            using (var contexto = new PetContext())
            {
                IList<Pessoa> pessoas = contexto.Pessoas.ToList();
                foreach (var item in pessoas)
                {
                    contexto.Pessoas.Remove(item);
                }
                contexto.SaveChanges();
            }
        }

        /*public void AtualizarPessoa(Pessoa pessoa)
        {
            using (var contexto = new PetContext())
            {
                contexto.Entry(pessoa).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }*/
    }
}