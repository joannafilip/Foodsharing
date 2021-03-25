using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Models
{
    public class SignUpModel
    {
        private string _nom, _prenom, _photo, _email, _numero, _rue, _ville, _cp, _login, _password, _telephone;
        private DateTime _dateNaiss;

        [Required]
        [MaxLength(50)]
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
        [MaxLength(50)]
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
        [MaxLength(323)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
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
        [Required]
        [MaxLength(5)]
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
        [Required]
        [MaxLength(100)]
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
        [Required]
        [MaxLength(50)]
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
        [Required]
        [MaxLength(5)]
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
        [Required]
        //[RegularExpression(@"^\d{4}-((0\d)|(1[012]))-(([012]\d)|3[01])$")]
        public DateTime DateNaiss
        {
            get
            {
                return _dateNaiss;
            }

            set
            {
                _dateNaiss = value;
            }
        }
        [Required]
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
        [Required]
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
