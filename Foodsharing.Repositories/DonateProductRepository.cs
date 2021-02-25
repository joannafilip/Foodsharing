using Foodsharing.DAL.Repositories;
using Foodsharing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Repositories
{
    public class DonateProductRepository : BaseRepository<DonateProductEntity>, IConcreteRepository<DonateProductEntity>
    {
        public DonateProductRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(DonateProductEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<DonateProductEntity> Get()
        {
            throw new NotImplementedException();
        }

        public DonateProductEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(DonateProductEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(DonateProductEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
