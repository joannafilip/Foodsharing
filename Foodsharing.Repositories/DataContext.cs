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
        IConcreteRepository<PropositionProductEntity> _propositionProductRepo;
        IConcreteRepository<MessageEntity> _messageRepo;
        IConcreteRepository<AdresseEntity> _adresseRepo;
        IConcreteRepository<UtilisateurEntity> _utilisateurRepo;

        public DataContext(string connectionString)
    {
        _productRepo = new ProductRepository(connectionString);
        _propositionProductRepo = new PropositionProductRepository(connectionString);
        _messageRepo = new MessageRepository(connectionString);
        _adresseRepo = new AdresseRepository(connectionString);
        _utilisateurRepo = new UtilisateurRepository(connectionString);
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
            
            AdresseEntity ae = new AdresseEntity();
            ae.Rue = sm.Rue;
            ae.Numero = sm.Numero;
            ae.Ville = sm.Ville;
            ae.CP = sm.CP;
            ae.IdUtilisateur = new List<UtilisateurEntity>();
            foreach (UtilisateurEntity item in ae.IdUtilisateur)
            {
                item.Nom = sm.Nom;
                item.Prenom = sm.Prenom;
                item.Email = sm.Email;
                item.DateNaiss = sm.DateNaiss;
                item.Photo = sm.Photo;
            }
            return _adresseRepo.Insert(ae);

        }

        public List<ProductContent> GetPropositionsProducts()
    {
            List<ProductContent> lpc = new List<ProductContent>(); //ModelVue
            List<PropositionProductEntity> propositionProductsFromDb = _propositionProductRepo.Get();
            List<ProductEntity> productsFromDb = _productRepo.Get();//Récupération mon entity
            List<UtilisateurEntity> usersFromDb = _utilisateurRepo.Get();//Récupération mon entity
            ProductContent pc = new ProductContent();
            foreach (ProductEntity produit in productsFromDb)
            {
                pc.Title = produit.Nom;
                pc.Text = produit.Description;
                pc.DatePeremption = produit.DatePeremption;
                pc.Bio = produit.Bio;
               
            }
              
            foreach (UtilisateurEntity utilisateur in usersFromDb)
            {
                pc.Nom = utilisateur.Nom;
                pc.Prenom = utilisateur.Prenom;
            }

            
            lpc.Add(pc);
            return lpc;
           
            //foreach (PropositionProductEntity item in propositionProductsFromDb)
            //{
            //    item.IdProduit = new List<ProductEntity>();
            //    item.IdUtilisateur = new List<UtilisateurEntity>();
            //    ProductContent pc= new ProductContent();//jeden product content

            //    foreach (ProductEntity produit in item.IdProduit)
            //    {
            //        pc.Title = produit.Nom;
            //        pc.Text = produit.Description;
            //        pc.DatePeremption = produit.DatePeremption;
            //        pc.Bio  = produit.Bio;
            //    }
            //    foreach (UtilisateurEntity utilisateur in item.IdUtilisateur)
            //    {
            //        pc.Utilisateur = utilisateur.Nom;

            //    }

            


        }






    }
}
