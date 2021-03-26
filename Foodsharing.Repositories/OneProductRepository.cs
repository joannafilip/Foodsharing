using Foodsharing.DAL.Repositories;
using Foodsharing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Repositories
{
    class OneProductRepository : BaseRepository<OneProductEntity>,
        IConcreteRepository<OneProductEntity>
    {
        public OneProductRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(OneProductEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<OneProductEntity> Get()
        {
            throw new NotImplementedException();
        }

        public OneProductEntity GetOne(int PK)
        {
            string requete = $@"Select * from V_GetAllProducts WHERE idProduit = @id";
            return base.GetOne(PK, requete);
        }

        public bool Insert(OneProductEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(OneProductEntity toUpdate)
        {
            throw new NotImplementedException();
        }

  
    }
}
