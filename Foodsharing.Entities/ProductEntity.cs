using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Entities
{
    public class ProductEntity
    {
        private int _idProduit, _quantite, _idMarque, _idType, _idEtat, _idPhoto, _idAdresse;
        private string _nom, _description;
        private DateTime _datePeremption;
        private bool _bio;
  
        public int IdProduit
        {
            get
            {
                return _idProduit;
            }

            set
            {
                _idProduit= value;
            }
        }
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
        public int IdMarque
        {
            get
            {
                return _idMarque;
            }

            set
            {
                _idMarque = value;
            }
        }
        public int IdType
        {
            get
            {
                return _idType;
            }

            set
            {
                _idType = value;
            }
        }
        public int IdEtat
        {
            get
            {
                return _idEtat;
            }

            set
            {
                _idEtat = value;
            }
        }
        public int IdPhoto
        {
            get
            {
                return _idPhoto;
            }

            set
            {
                _idPhoto = value;
            }
        }
        public int IdAdresse
        {
            get
            {
                return _idAdresse;
            }

            set
            {
                _idAdresse = value;
            }
        }
        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
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
                _bio= value;
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
    }
}
