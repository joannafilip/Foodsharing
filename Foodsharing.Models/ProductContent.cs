using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foodsharing.Models
{
    public class ProductContent
    {

        private string _title, _image, _text, _type, _nom, _prenom;
        private DateTime _datePeremption;
        private bool _bio;
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


    }
}