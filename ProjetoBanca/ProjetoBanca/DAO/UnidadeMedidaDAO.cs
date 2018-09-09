using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.DAO
{
    public class UnidadeMedidaDAO
    {
        public void Adicionar(UnidadeMedida unidadeMedida)
        {
            using (var contexto = new PetContext())
            {
                contexto.UnidadeMedidas.Add(unidadeMedida);
                contexto.SaveChanges();
            }
        }

        public IList<UnidadeMedida> ListarUnidadeMedida()
        {
            using (var contexto = new PetContext())
            {
                return contexto.UnidadeMedidas.ToList();
            }
        }

        public UnidadeMedida BuscaPorId(int id)
        {
            using (var contexto = new PetContext())
            {
                return contexto.UnidadeMedidas.Find(id);
            }
        }

        public void ExcluirUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            using (var contexto = new PetContext())
            {
                contexto.UnidadeMedidas.Remove(unidadeMedida);
                contexto.SaveChanges();
            }
        }

        public void AtualizarUnidadeMedida(UnidadeMedida unidadeMedida)
        {
            using (var contexto = new PetContext())
            {
                contexto.UnidadeMedidas.Update(unidadeMedida);
                contexto.SaveChanges();
            }
        }
    }
}