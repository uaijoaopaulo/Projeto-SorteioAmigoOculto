using AmigoOculto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoOculto.Repository
{
    public class RepositoryUsuario : RepositoryBase
    {
        public void NovoU(Usuario usuario)
        {
            DataModel.Entry(usuario).State = usuario.Id == 0 ?
                System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
            DataModel.SaveChanges();
        }
        public List<Usuario> GetAllU()
        {
            return DataModel.Usuario.ToList();
        }
        public Usuario GetOneU(string name)
        {
            try
            {
                return DataModel.Usuario.First(e => e.User == name);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public Usuario GetOneUN(string name)
        {
            try
            {
                return DataModel.Usuario.First(e => e.NomeCmp == name);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public Usuario GetOneUID(int id)
        {
            try
            {
                return DataModel.Usuario.First(e => e.Id == id);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
            
        }
        public void DeleteU(string name)
        {
            Usuario usuario = GetOneU(name);
            DataModel.Usuario.Remove(usuario);
            DataModel.SaveChanges();
        }
        public void Delete(int id)
        {
            Usuario usuario = GetOneUID(id);
            DataModel.Usuario.Remove(usuario);
            DataModel.SaveChanges();
        }

    }
}
