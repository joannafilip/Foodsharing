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
        IConcreteRepository<DonateProductEntity> _donateProductRepo;

        public DataContext(string connectionString)
    {
        _productRepo = new ProductRepository(connectionString);
        _messageRepo = new MessageRepository(connectionString);
        _utilisateurRepo = new UtilisateurRepository(connectionString);
        _typeRepo = new TypeRepository(connectionString);
        _signUpRepo = new SignUpRepository(connectionString);
        _donateProductRepo = new DonateProductRepository(connectionString);
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

        public bool InsertProduct(ProfilModel pf)
        {
            DonateProductEntity dpe = new DonateProductEntity();
            dpe.IdUtilisateur = pf.IdUser;
            dpe.IdAdresse = pf.IdAdresse;
            dpe.Quantite = pf.DonateProduct.Quantite;
            dpe.Type = pf.DonateProduct.Type;
            dpe.Nom = pf.DonateProduct.Nom;
            dpe.Bio = pf.DonateProduct.Bio;
            dpe.DateFin = pf.DonateProduct.DateFin;
            dpe.DatePeremption = pf.DonateProduct.DatePeremption;
            dpe.Photo = pf.DonateProduct.Photo;
            dpe.Description = pf.DonateProduct.Description;
            dpe.Etat = pf.DonateProduct.Etat;


            return _donateProductRepo.Insert(dpe);
        }
        public ProfilModel UserAuth(LoginModel lm)
        {
            UtilisateurEntity ue = ((UtilisateurRepository)_utilisateurRepo).GetFromLogin(lm.Login, lm.Password);
            if (ue == null) return null;
            if (ue != null) 
            {
                return new ProfilModel()
                {
                    IdAdresse = ue.IdAdresse,
                    IdUser = ue.IdUtilisateur,
                    Login = ue.Login,
                    Name = ue.Nom,
                    FirstName= ue.Prenom,
                    Birthdate=ue.DateNaiss,
                    Photo = ue.Photo,
                    Rue = ue.Rue,
                    Numero = ue.Numero,
                    Ville = ue.Ville,
                    CP = ue.CP

                };
            }
            else
            {
                return null;
            }
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
