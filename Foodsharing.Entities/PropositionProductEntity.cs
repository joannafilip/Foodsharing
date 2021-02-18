using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Entities
{
   public class PropositionProductEntity
    {
        private int _idProposition, _idUtilisateur, _idProduit;
        private DateTime _dateProposition, _dateFin;


        public int IdProposition
        {
            get
            {
                return _idProposition;
            }

            set
            {
                _idProposition = value;
            }
        }
        public int IdUtilisateur
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
                _dateFin= value;
            }
        }
    }
}
