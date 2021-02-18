﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foodsharing.Models
{
    public class ProductContent
    {

        private string _title, _image, _text, _type;
        private DateTime _datePeremption;
        private bool _bio;
        private int _utilisateur;
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
        public int Utilisateur
        {
            get
            {
                return _utilisateur;
            }

            set
            {
                _utilisateur = value;
            }
        }


    }
}