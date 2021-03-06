﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foodsharing.Models
{
    public class ProductContent
    {
        private int _quantite, _idProduit;
        private string _title, _image, _text, _type, _nom, _prenom, _etat, _marque;
        private DateTime _datePeremption, _dateProposition;
        private bool _bio;
        private int _maxProduct, _maxPage;


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
        public string Image
        {
            get
            {
                return _image;
            }

            set
            {
                _image = value;
            }
        }
        public string Text
        {
            get
            {
                return _text;
            }

            set
            {
                _text = value;
            }
        }
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
        public int MaxProduct
        {
            get
            {
                return _maxProduct;
            }

            set
            {
                _maxProduct = value;
            }
        }
        public int MaxPage
        {
            get
            {
                return _maxPage;
            }

            set
            {
                _maxPage = value;
            }
        }

    }
}