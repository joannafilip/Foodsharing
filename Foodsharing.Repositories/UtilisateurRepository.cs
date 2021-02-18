using Foodsharing.DAL.Repositories;
using Foodsharing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Repositories
{
        public class UtilisateurRepository : BaseRepository<UtilisateurEntity>,
       IConcreteRepository<UtilisateurEntity>
        {
            public UtilisateurRepository(string connectionString) : base(connectionString)
            {

            }

        public bool Delete(UtilisateurEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<UtilisateurEntity> Get()
        {
            throw new NotImplementedException();
        }

        public UtilisateurEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(UtilisateurEntity toInsert)
        {
            string requete = @"INSERT INTO Utilisateur (Nom, Prenom, DateNaiss, Email, Photo)
                               VALUES (@Nom,  @Prenom, @DateNaiss, @Email, @Photo";
            return base.Insert(toInsert, requete);
        }

        public bool Update(UtilisateurEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
    
}
