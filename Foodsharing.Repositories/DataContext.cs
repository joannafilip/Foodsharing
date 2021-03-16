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
        IConcreteRepository<GetSixLatestPrductsEntity> _getSixRepo;

        public DataContext(string connectionString)
    {
        _productRepo = new ProductRepository(connectionString);
        _messageRepo = new MessageRepository(connectionString);
        _utilisateurRepo = new UtilisateurRepository(connectionString);
        _typeRepo = new TypeRepository(connectionString);
        _signUpRepo = new SignUpRepository(connectionString);
        _donateProductRepo = new DonateProductRepository(connectionString);
        _getSixRepo = new GetSixLatestProductsRepository (connectionString);
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
            dpe.LabelType = pf.DonateProduct.Type;
            dpe.NameProduct = pf.DonateProduct.Nom;
            dpe.Bio = pf.DonateProduct.Bio;
            dpe.DateFin = pf.DonateProduct.DateFin;
            dpe.DatePeremption = pf.DonateProduct.DatePeremption;
            dpe.Src= pf.DonateProduct.Src;
            dpe.Description = pf.DonateProduct.Description;
            dpe.LabelEtat = pf.DonateProduct.Etat;
            dpe.DateProposition = pf.DonateProduct.DateProposition;
            dpe.Title = pf.DonateProduct.Title;
            dpe.Pays = pf.DonateProduct.Pays;
            dpe.NomMarque = pf.DonateProduct.Marque;


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
            List<GetSixLatestPrductsEntity> allProductsFromDb = ((GetSixLatestProductsRepository)_getSixRepo).GetAllProducts();//Récupération mon entity

            foreach (GetSixLatestPrductsEntity prod in allProductsFromDb)
            {
                ProductContent pc = new ProductContent();
                pc.Title = prod.NomProduit;
                pc.Text = prod.Description;
                pc.DatePeremption = prod.DatePeremption;
                pc.Bio = prod.Bio;
                pc.Quantite = prod.Quantite;
                pc.Nom = prod.Nom;
                pc.Prenom = prod.Prenom;
                pc.Type = prod.Type;

                lpc.Add(pc);
            }
            return lpc;
        }

        //List<ProductContent> lpc = new List<ProductContent>(); //ModelVue
        //List<ProductEntity> productsFromDb = _productRepo.Get();//Récupération mon entity
        //List<UtilisateurEntity> usersFromDb = _utilisateurRepo.Get();//Récupération mon entity
        //List<TypeEntity> typesFromDb = _typeRepo.Get();//Récupération mon entity

        //foreach (ProductEntity produit in productsFromDb)
        //{
        //    ProductContent pc = new ProductContent();
        //    pc.Title = produit.Nom;
        //    pc.Text = produit.Description;
        //    pc.DatePeremption = produit.DatePeremption;
        //    pc.Bio = produit.Bio;
        //    pc.Quantite = produit.Quantite;

        //    foreach (UtilisateurEntity utilisateur in usersFromDb)
        //    {
        //    pc.Nom = utilisateur.Nom;
        //    pc.Prenom = utilisateur.Prenom;
        //    }
        //    foreach (TypeEntity type in typesFromDb)
        //    {
        //    pc.Type = type.Label;
        //    }
        //    lpc.Add(pc);
        //    }

        //return lpc;
    //}

        public List<ProductContent> GetSixLatestProducts()
        {
            List<ProductContent> lpc = new List<ProductContent>(); //ModelVue
            List<GetSixLatestPrductsEntity> sixProductsFromDb = _getSixRepo.Get();//Récupération mon entity

            foreach (GetSixLatestPrductsEntity prod in sixProductsFromDb)
            {
                ProductContent pc = new ProductContent();
                    pc.Title = prod.NomProduit;
                    pc.Text = prod.Description;
                    pc.DatePeremption = prod.DatePeremption;
                    pc.Bio = prod.Bio;
                    pc.Quantite = prod.Quantite;
                    pc.Nom = prod.Nom;
                    pc.Prenom = prod.Prenom;
                    pc.Type = prod.Type;
                
                lpc.Add(pc);
            }
            return lpc;
        }


    }
}
