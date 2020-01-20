using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigoOculto.Model;

namespace AmigoOculto.Repository
{
    public class RepositoryResultado : RepositoryBase
    {
        public List<Sorteio> GetAllH()
        {
            return DataModel.Sorteio.ToList();
        }
        public Sorteio GetOneR(int id)
        {
            try
            {
                return DataModel.Sorteio.First(e => e.id_Usuario_Origem == id);
            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }
    }
}
