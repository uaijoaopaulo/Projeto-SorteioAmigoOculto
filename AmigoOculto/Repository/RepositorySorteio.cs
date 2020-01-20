using AmigoOculto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoOculto.Repository
{
    public class RepositorySorteio : RepositoryBase
    {
        public void Salvar(Sorteio sorteio)
        {
            DataModel.Entry(sorteio).State = sorteio.Id == 0 ?
                System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
            DataModel.SaveChanges();
        }
        public List<Sorteio> GetAll()
        {
            return DataModel.Sorteio.ToList();
        }
        public Sorteio GetOneG(int id_grupo)
        {
            try
            {
                return DataModel.Sorteio.First(e => e.id_Grupo == id_grupo);
            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }
        public Sorteio GetOne(int id)
        {
            try
            {
                return DataModel.Sorteio.First(e => e.Id == id);
            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }
        public Sorteio GetOneUD(int id_usuariodestino)
        {
            try
            {
                return DataModel.Sorteio.First(e => e.id_Usuario_Destino == id_usuariodestino);
            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }
        public Sorteio GetOneUO(int id_usuarioorigem)
        {
            try
            {
                return DataModel.Sorteio.First(e => e.id_Usuario_Origem == id_usuarioorigem);
            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }
        public void Delete(int id)
        {
            Sorteio sorteio = GetOne(id);
            if(sorteio != null)
            {
            DataModel.Sorteio.Remove(sorteio);
            DataModel.SaveChanges();
            }
        }
    }
}

