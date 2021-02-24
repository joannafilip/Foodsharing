using Foodsharing.DAL.Repositories;
using Foodsharing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Repositories
{
    public class TypeRepository : BaseRepository<TypeEntity>, IConcreteRepository<TypeEntity>
    {
        public TypeRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(TypeEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<TypeEntity> Get()
        {
            string requete = "Select * from Type";

            return base.Get(requete);
        }

        public TypeEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(TypeEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(TypeEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
