using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Entities
{
   public class UtilisateurEntity
    {
		private int _idUtilisateur;
		private string _nom, _prenom, _photo, _email;
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
    }
}
