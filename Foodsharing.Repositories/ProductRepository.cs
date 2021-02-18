using Foodsharing.DAL.Repositories;
using Foodsharing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Repositories
{
    public class ProductRepository : BaseRepository<ProductEntity>, IConcreteRepository<ProductEntity>
    {
        public ProductRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(ProductEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<ProductEntity> Get()
        {
            string requete = "Select * from Produit";

            return base.Get(requete);
        }

        public ProductEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ProductEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProductEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
