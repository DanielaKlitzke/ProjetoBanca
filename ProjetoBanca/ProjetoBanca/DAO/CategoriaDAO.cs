using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.DAO
{
    public class CategoriaDAO
    {
        public void Adicionar(Categoria categoria)
        {
            using (var contexto = new PetContext())
            {
                contexto.Categorias.Add(categoria);
                contexto.SaveChanges();
            }
        }

        public IList<Categoria> ListarCategoria()
        {
            using (var contexto = new PetContext())
            {
                return contexto.Categorias.ToList();
            }
        }

        public void ExcluirCategoria()
        {
            using (var contexto = new PetContext())
            {
                IList<Categoria> categorias = contexto.Categorias.ToList();
                foreach (var item in categorias)
                {
                    contexto.Categorias.Remove(item);
                }
                contexto.SaveChanges();
            }
        }

        /*public void AtualizarCategoria(Categoria categoria)
        {
            using (var contexto = new PetContext())
            {
                contexto.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }*/
    }
}