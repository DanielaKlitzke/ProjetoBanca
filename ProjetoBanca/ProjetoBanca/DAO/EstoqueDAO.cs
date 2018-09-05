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

        public IList<Estoque> ListarEstoque()
        {
            using (var contexto = new PetContext())
            {
                return contexto.Estoques.ToList();
            }
        }

        public void ExcluirEstoque(Estoque estoque)
        {
            using (var contexto = new PetContext())
            {
                contexto.Estoques.Remove(estoque);
                contexto.SaveChanges();
            }
        }

        public void AtualizarEstoque(Estoque estoque)
        {
            using (var contexto = new PetContext())
            {
                contexto.Estoques.Update(estoque);
                contexto.SaveChanges();
            }
        }
    }
}