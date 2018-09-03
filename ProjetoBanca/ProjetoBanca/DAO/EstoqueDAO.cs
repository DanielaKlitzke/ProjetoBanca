﻿using ProjetoBanca.Models;
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

        public void ExcluirEstoque()
        {
            using (var contexto = new PetContext())
            {
                IList<Estoque> estoques = contexto.Estoques.ToList();
                foreach (var item in estoques)
                {
                    contexto.Estoques.Remove(item);
                }
                contexto.SaveChanges();
            }
        }

        /*public void AtualizarEstoque(Esoque estoque)
        {
            using (var contexto = new PetContext())
            {
                contexto.Entry(estoque).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }*/
    }
}