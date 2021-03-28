using Foodsharing.DAL.Repositories;
using Foodsharing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Repositories
{
    class GetSixLatestProductsRepository : BaseRepository<GetSixLatestPrductsEntity>, IConcreteRepository<GetSixLatestPrductsEntity>
    {
        public GetSixLatestProductsRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(GetSixLatestPrductsEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<GetSixLatestPrductsEntity> Get()
        {
            string requete = "Select * from V_GetSixLatestProducts";

            return base.Get(requete);
        }
        public List<GetSixLatestPrductsEntity> GetAllProducts()
        {
            string requete = "Select * from V_GetAllProducts";

            return base.Get(requete);
        }
        public List<GetSixLatestPrductsEntity> GetAllProductsFromMembre(int idUtilisateur)
        {
            string requete = "EXEC [dbo].[SP_RecupProduitsMembre]" + @idUtilisateur;

            return base.Get(requete);
        }

        public GetSixLatestPrductsEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }
        public List<GetSixLatestPrductsEntity> GetProductEntityByType(string type)
        {
            string requete = @"EXEC [SP_GetTypeProduit] '" + type + "'";
            return base.Get(requete);
        }
        public List<GetSixLatestPrductsEntity> GetProductEntityByPage( int page, string searchString, string type, string sortOrder)
        {
            string requete = $@"Select * from V_GetAllProducts";

            if (!String.IsNullOrEmpty(searchString))
            {
                requete += " WHERE NomProduit LIKE '%" + searchString + "%' ";
                if (!String.IsNullOrEmpty(type))
                {
                    requete += $" AND Type = '{type}' ";
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(type))
                {
                    requete += $" WHERE Type = '{type}' ";
                }
            }

            switch (sortOrder)
            {
                case "name_desc":
                    requete += " ORDER BY NomProduit DESC ";
                    break;
                case "date_asc":
                    requete += " ORDER BY DatePeremption ASC ";
                    break;
                case "date_desc":
                    requete += " ORDER BY DatePeremption DESC ";
                    break;
                default:
                    requete += " ORDER BY NomProduit ";
                    break;
            }


            int nbPerPage = 6;
            int skip = (page - 1) * nbPerPage;
            requete += $@" OFFSET {skip} ROWS 
                        FETCH NEXT {nbPerPage} ROWS ONLY ";
            return base.Get(requete);
        }

        public List<GetSixLatestPrductsEntity> GetProductEntityAllPage(int page, string searchString, string type, string sortOrder)
        {
            string requete = $@"SELECT * FROM V_GetAllProducts";

            if (!String.IsNullOrEmpty(searchString))
            {
                requete += " WHERE NomProduit LIKE '%" + searchString + "%' ";
                if (!String.IsNullOrEmpty(type))
                {
                    requete += $" AND Type = '{type}' ";
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(type))
                {
                    requete += $" WHERE Type = '{type}' ";
                }
            }
            switch (sortOrder)
            {
                case "name_desc":
                    requete += " ORDER BY NomProduit DESC ";
                    break;
                case "date_asc":
                    requete += " ORDER BY DatePeremption ASC ";
                    break;
                case "date_desc":
                    requete += " ORDER BY DatePeremption DESC ";
                    break;
                default:
                    requete += " ORDER BY NomProduit ";
                    break;
            }

            return base.Get(requete);
        }

        public bool Insert(GetSixLatestPrductsEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(GetSixLatestPrductsEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
