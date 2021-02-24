
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
            string requete = "Select IdUtilisateur, IdProduit from PropositionProduit";
            //string requete = "SELECT dbo.Utilisateur.Nom, dbo.PropositionProduit.IdUtilisateur, dbo.PropositionProduit.IdProduit, dbo.Produit.Nom, dbo.Produit.DatePeremption, dbo.Produit.Description, dbo.Produit.Bio FROM dbo.Produit INNER JOIN dbo.PropositionProduit ON dbo.Produit.IdProduit = dbo.PropositionProduit.IdProduit INNER JOIN dbo.Utilisateur ON dbo.PropositionProduit.IdUtilisateur = dbo.Utilisateur.IdUtilisateur";
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
