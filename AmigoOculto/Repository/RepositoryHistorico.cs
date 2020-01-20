using AmigoOculto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoOculto.Repository
{
    public class RepositoryHistorico : RepositoryBase
    {
        public void NovoH(Historico historico)
        {
            DataModel.Entry(historico).State = historico.Id == 0 ?
                System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
            DataModel.SaveChanges();
        }
        public List<Historico> GetAllH()
        {
            return DataModel.Historico.ToList();
        }
        public Historico GetOneH(bool ativ)
        {
            try
            {
                return DataModel.Historico.First(e => e.Ativo == ativ);
            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }
        public Historico GetOneIDH(int id)
        {
            try
            {
                return DataModel.Historico.First(e => e.Id == id);
            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }
        public Historico GetOneHDT(DateTime date)
        {
            try
            {
                return DataModel.Historico.First(e => e.DataEntrada < date);
            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }
        public Historico GetOneHN(string name)
        {
            try
            {
                return DataModel.Historico.First(e => e.Nome.Equals(name));
            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }
        public void Delete(int id)
        {
            Historico hist = GetOneIDH(id);
            DataModel.Historico.Remove(hist);
            DataModel.SaveChanges();
        }
    }
}
