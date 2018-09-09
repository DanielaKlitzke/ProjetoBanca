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

        public Categoria BuscaPorId(int id)
        {
            using (var contexto = new PetContext())
            {
                return contexto.Categorias.Find(id);
            }
        }

        public void ExcluirCategoria(Categoria categoria)
        {
            using (var contexto = new PetContext())
            {
                contexto.Categorias.Remove(categoria);
                contexto.SaveChanges();
            }
        }

        public void AtualizarCategoria(Categoria categoria)
        {
            using (var contexto = new PetContext())
            {
                contexto.Categorias.Update(categoria);
                contexto.SaveChanges();
            }
        }
    }
}