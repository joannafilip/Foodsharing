using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foodsharing.Models
{
    public class Widget
    {
        private string _title, _image, _underTitle;
        private DateTime _date;
        private int _number;

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
        public string UnderTitle
        {
            get
            {
                return _underTitle;
            }

            set
            {
                _underTitle = value;
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
        public int Number
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

    }
}