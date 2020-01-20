using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigoOculto.Model;

namespace AmigoOculto.Repository
{
    public class RepositoryBase
    {
        private DataEntities _DataModel;
        public DataEntities DataModel
        {
            get
            {
                if (_DataModel == null)
                {
                    _DataModel = new DataEntities();
                }
                return _DataModel;
            }
        }
    }
}
