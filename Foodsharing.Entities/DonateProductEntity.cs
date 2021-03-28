using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Entities
{
   public class DonateProductEntity
    {
        private int _quantite, _idAdresse, _idUtilisateur, _idType;
        private string _nameProduct, _description, _labelType, _src, _labelEtat, _title, _nomMarque, _pays;
        private DateTime _datePeremption, _dateFin, _dateProposition;
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
        public string NameProduct
        {
            get
            {
                return _nameProduct;
            }

            set
            {
                _nameProduct= value;
            }
        }
        public string LabelType
        {
            get
            {
                return _labelType;
            }

            set
            {
                _labelType = value;
            }
        }
        public string LabelEtat
        {
            get
            {
                return _labelEtat;
            }

            set
            {
                _labelEtat= value;
            }
        }
        public string Src
        {
            get
            {
                return _src;
            }

            set
            {
                _src = value;
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
        public DateTime DateFin
        {
            get
            {
                return _dateFin;
            }

            set
            {
                _dateFin = value;
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
        public int IdUtilisateur
        {
            get
            {
                return _idUtilisateur;
            }

            set
            {
                _idUtilisateur = value;
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
        public string NomMarque
        {
            get
            {
                return _nomMarque;
            }

            set
            {
                _nomMarque = value;
            }
        }
        public string Pays
        {
            get
            {
                return _pays;
            }

            set
            {
                _pays = value;
            }
        }
    }
}
