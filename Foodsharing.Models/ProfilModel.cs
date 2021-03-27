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
        private int _idUser, _idAdresse;
        private string _name, _firstName, _login, _email, _numero, _ville, _photo, _cp, _password, _rue, _telephone;
        private DateTime _birthDate;
        private DonateProductModel _donateProduct;
        private List<DonateProductModel> _listDonateProducts;


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
      public string Ville
        {
            get
            {
                return _ville;
            }

            set
            {
                _ville = value;
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
        public string Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
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
        public string Rue
        {
            get
            {
                return _rue;
            }

            set
            {
                _rue = value;
            }
        }
        public DonateProductModel DonateProduct
        {
            get
            {
                return _donateProduct;
            }

            set
            {
                _donateProduct = value;
            }
        }
        public List <DonateProductModel> ListDonateProducts
        {
            get
            {
                return _listDonateProducts;
            }

            set
            {
                _listDonateProducts = value;
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
        public string Telephone
        {
            get
            {
                return _telephone;
            }

            set
            {
                _telephone = value;
            }
        }
    }
}

