using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBanca.DAO
{
    public class UsuarioDAO
    {
        public void Adicionar(Usuario usuario)
        {
            using (var contexto = new PetContext())
            {
                contexto.Usuarios.Add(usuario);
                contexto.SaveChanges();
            }
        }

        public IList<Usuario> ListarUsuario()
        {
            using (var contexto = new PetContext())
            {
                return contexto.Usuarios.ToList();
            }
        }

        public void ExcluirUsuario()
        {
            using (var contexto = new PetContext())
            {
                IList<Usuario> usuarios = contexto.Usuarios.ToList();
                foreach (var item in usuarios)
                {
                    contexto.Usuarios.Remove(item);
                }
                contexto.SaveChanges();
            }
        }

        /*public void AtualizarUsuario(Usuario usuario)
        {
            using (var contexto = new PetContext())
            {
                contexto.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }*/
    }
}