﻿using Foodsharing.DAL.Repositories;
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

        public List<GetSixLatestPrductsEntity> GetProductAllPage(string sortOrder,  string searchString, int page)
        {
            string requete = $@"Select * from V_GetAllProducts";

            if (!String.IsNullOrEmpty(searchString))
            {
                requete += " WHERE NomProduit LIKE '%" + searchString + "%' ";
            }
            switch (sortOrder)
            {
                case "name_desc":
                    requete += " order by NomProduit DESC ";
                    break;
                case "Date":
                    requete += " order by DatePeremption ASC ";
                    break;
                case "date_desc":
                    requete += " order by DatePeremption  DESC ";
                    break;
                default:
                    requete += " order by NomProduit ";
                    break;
            }



            int nbParPage = 5;
            int skip = (page - 1) * 5;
            requete += $@"  OFFSET  {skip} ROWS 
                                FETCH NEXT {nbParPage} ROWS ONLY";

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
