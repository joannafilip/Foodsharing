using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Entities
{
   public class UtilisateurEntity
    {
		private int _idUtilisateur, _idAdresse;
		private string _nom, _prenom, _photo, _email, _login, _password, _salt, _rue, _cp, _ville, _numero, _telephone;
		private DateTime _dateNaiss;
    

        public int IdUtilisateur
        {
            get
            {
                return _idUtilisateur;
            }

            set
            {
                _idUtilisateur= value;
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
        public DateTime DateNaiss
        {
            get
            {
                return _dateNaiss;
            }

            set
            {
                _dateNaiss= value;
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
        public string Salt
        {
            get
            {
                return _salt;
            }

            set
            {
                _salt = value;
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
        public string CP
        {
            get
            {
                return _cp;
            }

            set
            {
                _cp= value;
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
