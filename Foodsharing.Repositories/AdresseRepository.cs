﻿using Foodsharing.DAL.Repositories;
using Foodsharing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Repositories
{
    public class AdresseRepository : BaseRepository<AdresseEntity>,
        IConcreteRepository<AdresseEntity>
    {
        public AdresseRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(AdresseEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<AdresseEntity> Get()
        {
            throw new NotImplementedException();
        }

        public AdresseEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(AdresseEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(AdresseEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
