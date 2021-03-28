using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Entities
{
    public class GetSixLatestPrductsEntity
    {
        private int _quantite, _idProduit;
        private string _nomProduit, _description, _marque, _utilisateurNom, _prenom, _title, _label, _photo;
        private DateTime _datePeremption, _dateProposition;
        private bool _bio;


        public int Quantite
        {
            get
            {
                return _quantite;
            }

            set
            {
                _quantite = value;
            }
        }
        public int IdProduit
        {
            get
            {
                return _idProduit;
            }

            set
            {
                _idProduit = value;
            }
        }
        public string Nom
        {
            get
            {
                return _utilisateurNom;
            }

            set
            {
                _utilisateurNom = value;
            }
        }
        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;
            }
        }
        public string NomProduit
        {
            get
            {
                return _nomProduit;
            }

            set
            {
                _nomProduit = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }
        public bool Bio
        {
            get
            {
                return _bio;
            }

            set
            {
                _bio = value;
            }
        }
        public DateTime DatePeremption
        {
            get
            {
                return _datePeremption;
            }

            set
            {
                _datePeremption = value;
            }
        }
        public DateTime DateProposition
        {
            get
            {
                return _dateProposition;
            }

            set
            {
                _dateProposition = value;
            }
        }

        public string Marque
        {
            get
            {
                return _marque;
            }

            set
            {
                _marque = value;
            }
        }
        public string Type
        {
            get
            {
                return _label;
            }

            set
            {
                _label= value;
            }
        }
        public string Photo
        {
            get
            {
                return _photo;
            }

            set
            {
                _photo = value;
            }
        }
    }
}
