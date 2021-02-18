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


        public DataContext(string connectionString)
    {
        _productRepo = new ProductRepository(connectionString);
        _propositionProductRepo = new PropositionProductRepository(connectionString);
        _messageRepo = new MessageRepository(connectionString);

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

    public List <ProductContent> GetPropositionsProducts()
    {
            List<ProductContent> lpc = new List<ProductContent>(); //ModelVue
            List<ProductEntity> pe = new List<ProductEntity>();
            //Récupération de mon entity
            List<PropositionProductEntity> propositionProductsFromDb = _propositionProductRepo.Get();
            foreach (PropositionProductEntity item in propositionProductsFromDb)
            {
                ProductContent pc = new ProductContent();
                pc.Utilisateur = item.IdUtilisateur;

                foreach (ProductEntity produit in pe)
                {
                    pc.Title = produit.Nom;
                    pc.Text = produit.Description;
                    pc.DatePeremption = produit.DatePeremption;
                    pc.Bio  = produit.Bio;
                }
                 
                
            }
            return lpc;


        }






    }
}
