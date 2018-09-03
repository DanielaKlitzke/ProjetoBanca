using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.DAO
{
    public class ProdutosDAO
    {
        public void Adicionar(Produtos produtos)
        {
            using (var contexto = new PetContext())
            {
                contexto.Produtos.Add(produtos);
                contexto.SaveChanges();
            }
        }

        public IList<Produtos> ListarProduto()
        {
            using (var contexto = new PetContext())
            {
                return contexto.Produtos.ToList();
            }
        }

        public void ExcluirProduto()
        {
            using (var contexto = new PetContext())
            {
                IList<Produtos> produtos = contexto.Produtos.ToList();
                foreach (var item in produtos)
                {
                    contexto.Produtos.Remove(item);
                }
                contexto.SaveChanges();
            }
        }

        /*public void AtualizarProduto(Produtos produto)
        {
            using (var contexto = new PetContext())
            {
                contexto.Entry(produto).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }*/
    }
}