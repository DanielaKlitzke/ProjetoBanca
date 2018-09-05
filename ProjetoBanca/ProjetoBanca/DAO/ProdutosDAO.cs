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

        public void ExcluirProduto(Produtos produtos)
        {
            using (var contexto = new PetContext())
            {
                {
                    contexto.Produtos.Remove(produtos);
                }
                contexto.SaveChanges();
            }
        }

        public void AtualizarProduto(Produtos produto)
        {
            using (var contexto = new PetContext())
            {
                contexto.Produtos.Update(produto);
                contexto.SaveChanges();
            }
        }
    }
}