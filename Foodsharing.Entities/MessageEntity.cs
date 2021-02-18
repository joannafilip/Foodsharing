using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Entities
{
    public class MessageEntity
    {
        int _idMessage;
        string _nom, _email, _phone, _information, _subject;

        public int IdMessage
        {
            get
            {
                return _idMessage;
            }

            set
            {
                _idMessage = value;
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

        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }

        public string Information
        {
            get
            {
                return _information;
            }

            set
            {
                _information = value;
            }
        }

        public string Subject
        {
            get
            {
                return _subject;
            }

            set
            {
                _subject = value;
            }
        }
    }
}
