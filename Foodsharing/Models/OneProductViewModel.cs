using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foodsharing.Models
{
    public class OneProductViewModel
    {
        private DonateProductModel _targetProduct;
        private List<ProductContent> _product;
        public DonateProductModel TargetProduct
        {
            get
            {
                return _targetProduct;
            }

            set
            {
                _targetProduct = value;
            }
        }
        public List<ProductContent> Product
        {
            get
            {
                return _product;
            }

            set
            {
                _product = value;
            }
        }
    }
}