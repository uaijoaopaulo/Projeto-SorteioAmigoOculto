using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigoOculto.Model;

namespace AmigoOculto.Repository
{
    public class RepositoryGrupo : RepositoryBase
    {
        public List<Grupo> GetAllU()
        {
            return DataModel.Grupo.ToList();
        }
        public void Salvar(Grupo grupo)
        {
            DataModel.Entry(grupo).State = grupo.Id == 0 ?
                System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
            DataModel.SaveChanges();
        }
        public Grupo GetOneID(int id)
        {
            try
            {
                return DataModel.Grupo.First(e => e.Id == id);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public void Delete(int id)
        {
            Grupo grupo = GetOneID(id);
            DataModel.Grupo.Remove(grupo);
            DataModel.SaveChanges();
        }
    }
}
