using Foodsharing.DAL.Repositories;
using Foodsharing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Repositories
{
   public class SignUpRepository : BaseRepository<SignUpEntity>, IConcreteRepository<SignUpEntity>
    {
        public SignUpRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(SignUpEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<SignUpEntity> Get()
        {
            return base.Get("Select * from Utilisateur");
        }
    

        public SignUpEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(SignUpEntity toInsert)
        {
            string requete = @"EXECUTE [dbo].[SP_Adresse_Insert] 
                                                        @numero
                                                        ,@rue
                                                        ,@ville
                                                        ,@cp
                                                        ,@nom
                                                        ,@prenom
                                                        ,@dateNaiss
                                                        ,@email
                                                        ,@photo
                                                        ,@login
                                                        ,@password";
            return base.Insert(toInsert, requete);
        }

        public bool Update(SignUpEntity toUpdate)
        {
            throw new NotImplementedException();
        }

    }
}
