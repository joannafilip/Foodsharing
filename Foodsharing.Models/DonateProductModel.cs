﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Models
{
    public class DonateProductModel
    {
        private int _quantite, _idType;
        private string _nom, _description, _type, _src, _etat, _pays, _marque, _title;
        private DateTime _datePeremption, _dateFin, _dateProposition ;
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
        public int IdType
        {
            get
            {
                return _idType;
            }

            set
            {
                _idType= value;
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
        [Required]
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
        [Required]
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
    }
}
