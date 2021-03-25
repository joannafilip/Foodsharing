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

        public GetSixLatestPrductsEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public List<GetSixLatestPrductsEntity> GetProductEntityByPage( int page)
        {
            string requete = $@"Select * from V_GetAllProducts order by NomProduit ";

            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    requete += " WHERE NomProduit LIKE '%" + searchString + "%' ";
            //}
            //switch (sortOrder)
            //{
            //    case "name_desc":
            //        requete += " order by NomProduit DESC ";
            //        break;
            //    case "Date":
            //        requete += " order by DatePeremption ASC ";
            //        break;
            //    case "date_desc":
            //        requete += " order by DatePeremption  DESC ";
            //        break;
            //    default:
            //        requete += " order by NomProduit ";
            //        break;
            //}



            int nbParPage = 5;
            int skip = (page - 1) * 5;
            requete += $@"  OFFSET  {skip} ROWS 
                                FETCH NEXT {nbParPage} ROWS ONLY";

            return base.Get(requete);
        }

        public List<GetSixLatestPrductsEntity> GetProductEntityAllPage(int page)
        {
            string requete = $@"SELECT * FROM V_GetAllProducts";

            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    requete += " WHERE ClassName LIKE '%" + searchString + "%' ";
            //    if (!String.IsNullOrEmpty(category))
            //    {
            //        requete += $" AND CategoryName = '{category}' ";
            //    }
            //}
            //else
            //{
            //    if (!String.IsNullOrEmpty(category))
            //    {
            //        requete += $" WHERE CategoryName = '{category}' ";
            //    }
            //}

            //switch (sortOrder)
            //{
            //    case "price_desc":
            //        requete += " ORDER BY Price DESC ";
            //        break;
            //    case "price_asc":
            //        requete += " ORDER BY Price ASC ";
            //        break;
            //    case "date_desc":
            //        requete += " ORDER BY Date DESC ";
            //        break;
            //    default:
            //        requete += " ORDER BY Date ";
            //        break;
            //}
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
