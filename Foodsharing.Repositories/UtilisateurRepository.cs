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
            string requete = "Select  [Login], Nom, Prenom, DateNaiss, Photo, Email from Utilisateur";
            return base.Get(requete);
        }

        public UtilisateurEntity GetFromLogin(string login, string password)
        {
            string requete = @" EXEC [dbo].[SP_Check_Password] 
                                                        @login,
                                                        @password";
            Dictionary<string, object> parametre = new Dictionary<string, object>();
            parametre.Add("login", login);
            parametre.Add("password", password);

            return base.Get(requete, parametre).FirstOrDefault();
        }

        public UtilisateurEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(UtilisateurEntity toInsert)
        {
            string requete = @"INSERT INTO Utilisateur (Nom, Prenom, DateNaiss, Email, Photo, Telephone)
                               VALUES (@Nom,  @Prenom, @DateNaiss, @Email, @Photo, @Telephone)";
            return base.Insert(toInsert, requete);
        }

        public bool Update(UtilisateurEntity toUpdate)
        {
            throw new NotImplementedException();
        }
        public bool UpdatePhoto(UtilisateurEntity toUpdate)
        {
            string request = @"UPDATE [Utilisateur]
                        SET [Photo]=@Photo
                        WHERE IdUtilisateur=@IdUtilisateur";
            return base.Update(toUpdate, request);
        }
    }
    
}
