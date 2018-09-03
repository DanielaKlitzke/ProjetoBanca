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

        public void ExcluirUnidadeMedida()
        {
            using (var contexto = new PetContext())
            {
                IList<UnidadeMedida> unidadeMedidas = contexto.UnidadeMedidas.ToList();
                foreach (var item in unidadeMedidas)
                {
                    contexto.UnidadeMedidas.Remove(item);
                }
                contexto.SaveChanges();
            }
        }

        /*public void AtualizarUnidadeMedida(UnidadeMedida unidadeMdida)
        {
            using (var contexto = new PetContext())
            {
                contexto.Entry(unidadeMedida).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }*/
    }
}