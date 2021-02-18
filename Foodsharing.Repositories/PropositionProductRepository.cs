
using Foodsharing.DAL.Repositories;
using Foodsharing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Repositories
{
   public class PropositionProductRepository: BaseRepository<PropositionProductEntity>, IConcreteRepository<PropositionProductEntity>
    {
        public PropositionProductRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(PropositionProductEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<PropositionProductEntity> Get()
        {
            string requete = "Select IdUtilisateur, IdProduit, DateProposition, DateFin from PropositionProduit";

            return base.Get(requete);
        }

        public PropositionProductEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(PropositionProductEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(PropositionProductEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
