using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodsharing.Entities
{
    public class TypeEntity
    {
        private int _idType;
        private string _label;

        public int IdType
        {
            get
            {
                return _idType;
            }

            set
            {
                _idType = value;
            }
        }
        public string Label
        {
            get
            {
                return _label;
            }

            set
            {
                _label = value;
            }
        }
    }
}
