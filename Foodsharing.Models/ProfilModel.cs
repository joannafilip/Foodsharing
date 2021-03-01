using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Models
{
    public class ProfilModel
    {
        private int _idUser;
        private string _name, _firstName, _login, _email, _number, _city, _photo, _cp, _street, _password;
        private DateTime _birthDate;


        public int IdUser
        {
            get
            {
                return _idUser;
            }

            set
            {
                _idUser = value;
            }
        }
       
        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }
    
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

   
        public string Login
        {
            get
            {
                return _login;
            }

            set
            {
                _login = value;
            }
        }


        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }
      public string City
        {
            get
            {
                return _city;
            }

            set
            {
                _city = value;
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
        public string Number
        {
            get
            {
                return _number;
            }

            set
            {
                _number = value;
            }
        }
        public DateTime Birthdate
        {
            get
            {
                return _birthDate;
            }

            set
            {
                _birthDate = value;
            }
        }
        public string CP
        {
            get
            {
                return _cp;
            }

            set
            {
                _cp = value;
            }
        }
        public string Street
        {
            get
            {
                return _street;
            }

            set
            {
                _street = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }
    }
}

