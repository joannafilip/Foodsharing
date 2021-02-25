using Foodsharing.DAL.Repositories;
using Foodsharing.Entities;
using Foodsharing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Foodsharing.Repositories
{
    public class DataContext
    {
        IConcreteRepository<ProductEntity> _productRepo;
        IConcreteRepository<MessageEntity> _messageRepo;
        IConcreteRepository<UtilisateurEntity> _utilisateurRepo;
        IConcreteRepository<TypeEntity> _typeRepo;
        IConcreteRepository<SignUpEntity> _signUpRepo;

        public DataContext(string connectionString)
    {
        _productRepo = new ProductRepository(connectionString);
        _messageRepo = new MessageRepository(connectionString);
        _utilisateurRepo = new UtilisateurRepository(connectionString);
        _typeRepo = new TypeRepository(connectionString);
        _signUpRepo = new SignUpRepository(connectionString);
        }

        public bool SaveContact(ContactModel cm)
        {
            MessageEntity me = new MessageEntity();
            me.Nom = cm.Nom;
            me.Email = cm.Email;
            me.Phone = cm.Phone;
            me.Information = cm.Message;
            me.Subject = cm.Subject;

            return _messageRepo.Insert(me);

        }
        public bool SaveSignUp(SignUpModel sm)
        {
            
            SignUpEntity signUp= new SignUpEntity();
            signUp.Rue = sm.Rue;
            signUp.Numero = sm.Numero;
            signUp.Ville = sm.Ville;
            signUp.CP = sm.CP;
            signUp.Nom = sm.Nom;
            signUp.Prenom = sm.Prenom;
            signUp.Email = sm.Email;
            signUp.DateNaiss = sm.DateNaiss;
            signUp.Photo = sm.Photo;
            signUp.Password = sm.Password;
            signUp.Login = sm.Login;
           
            return _signUpRepo.Insert(signUp);

        }
        public bool UserAuth(LoginModel lm)
        {
            UtilisateurEntity ue = ((UtilisateurRepository)_utilisateurRepo).GetFromLogin(lm.Login, lm.Password);
            return ue != null;

        }

        public List<ProductContent> GetPropositionsProducts()
    {
            List<ProductContent> lpc = new List<ProductContent>(); //ModelVue
            List<ProductEntity> productsFromDb = _productRepo.Get();//Récupération mon entity
            List<UtilisateurEntity> usersFromDb = _utilisateurRepo.Get();//Récupération mon entity
            List<TypeEntity> typesFromDb = _typeRepo.Get();//Récupération mon entity
            
            foreach (ProductEntity produit in productsFromDb)
            {
                ProductContent pc = new ProductContent();
                pc.Title = produit.Nom;
                pc.Text = produit.Description;
                pc.DatePeremption = produit.DatePeremption;
                pc.Bio = produit.Bio;
                pc.Quantite = produit.Quantite;
               
                foreach (UtilisateurEntity utilisateur in usersFromDb)
                {
                pc.Nom = utilisateur.Nom;
                pc.Prenom = utilisateur.Prenom;
                }
                foreach (TypeEntity type in typesFromDb)
                {
                pc.Type = type.Label;
                }
                lpc.Add(pc);
                }
           
            return lpc;
        }

    






    }
}
