using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Models
{
    public class ContactModel
    {
        private string _nom, _email, _phone, _message, _subject, _title, _text;

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
                _email= value;
            }
        }
        [Required]
        [MaxLength(12)]
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
        [Required]
        public string Message
        {
            get
            {
                return _message;
            }

            set
            {
                _message = value;
            }
        }
        [Required]
        [MaxLength(150)]
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
    }
}
