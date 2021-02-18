using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Models
{
    public class MainImageContent
    {
        private string _title, _image, _type, _autor;
        private DateTime _date;
   
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
        public DateTime Date
        {
            get
            {
                return _date;
            }

            set
            {
                _date = value;
            }
        }
        public string Autor
        {
            get
            {
                return _autor;
            }

            set
            {
                _autor = value;
            }
        }
    }
}
