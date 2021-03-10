using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Models
{
    public class DonateProductModel
    {
        private int _quantite;
        private string _nom, _description, _type, _photo, _etat;
        private DateTime _datePeremption, _dateFin;
        private bool _bio;

        [Required]
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
        [Required]
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
        [Required]
        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }
        [Required]
        public string Etat
        {
            get
            {
                return _etat;
            }

            set
            {
                _etat = value;
            }
        }
        [Required]
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
        [Required]
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
        [Required]
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
        [Required]
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
        [Required]
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
    }
}
