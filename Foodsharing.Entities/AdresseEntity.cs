using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Entities
{
	public class AdresseEntity
	{
        private int _idAdresse;
        private string _numero, _rue, _ville, _cp;
        private List<UtilisateurEntity> _idUtilisateur;

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
        public string Rue
        {
            get
            {
                return _rue;
            }

            set
            {
                _rue= value;
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
                _cp = value;
            }
        }
        public List<UtilisateurEntity>IdUtilisateur
        {
            get
            {
                return _idUtilisateur;
            }

            set
            {
                _idUtilisateur = value;
            }
        }
    }
}
