using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigoOculto.Model;

namespace AmigoOculto.Repository
{
    public class RepositoryGrupoUsuario : RepositoryBase
    {
        public void Salvar(Grupo_Usuario grupo)
        {
            DataModel.Entry(grupo).State = grupo.Id == 0 ?
                System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
            DataModel.SaveChanges();
        }
        public Grupo_Usuario GetOneID(int id)
        {
            try
            {
                return DataModel.Grupo_Usuario.First(e => e.Id == id);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public Grupo_Usuario GetOneIDU(int id)
        {
            try
            {
                return DataModel.Grupo_Usuario.First(e => e.id_Usuario == id);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public List<Grupo_Usuario> GetAllU()
        {
            return DataModel.Grupo_Usuario.ToList();
        }
        public List<Grupo_Usuario> GetAllByIdGrupoU(int idGrupo)
        {
            return DataModel.Grupo_Usuario.Where(e => e.id_Grupo == idGrupo ).ToList();
        }

        public void Delete(int id)
        {
            Grupo_Usuario grupo = GetOneID(id);

            DataModel.Grupo_Usuario.Remove(grupo);
            DataModel.SaveChanges();
        }
        public void DeleteU(int id)
        {
            Grupo_Usuario grupo = GetOneIDU(id);

            DataModel.Grupo_Usuario.Remove(grupo);
            DataModel.SaveChanges();
        }
    }
}
