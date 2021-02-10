using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foodsharing.Models
{
    public class ProductViewModel
    {
        private List<ProductContent> _product;
        public ProductViewModel()
        {
            Product = new List<ProductContent>();
            Product.Add(new ProductContent() { Title = "The best twenty plant species you can look at at home", Image = "garden_sq_01.jpg", Text= "Aenean interdum arcu blandit, vehicula magna non, placerat elit. Mauris et pharetratortor. Suspendissea sodales urna. In at augue elit. Vivamus enim nibh, maximus ac felis nec, maximus tempor odio.", Type= "Indoor" });
            Product.Add(new ProductContent() { Title = "The best twenty plant species you can look at at home", Image = "garden_sq_02.jpg", Text = "Aenean interdum arcu blandit, vehicula magna non, placerat elit. Mauris et pharetratortor. Suspendissea sodales urna. In at augue elit. Vivamus enim nibh, maximus ac felis nec, maximus tempor odio.", Type = "Indoor" });
            Product.Add(new ProductContent() { Title = "The best twenty plant species you can look at at home", Image = "garden_sq_03.jpg", Text = "Aenean interdum arcu blandit, vehicula magna non, placerat elit. Mauris et pharetratortor. Suspendissea sodales urna. In at augue elit. Vivamus enim nibh, maximus ac felis nec, maximus tempor odio.", Type = "Indoor" });
            Product.Add(new ProductContent() { Title = "The best twenty plant species you can look at at home", Image = "garden_sq_04.jpg", Text = "Aenean interdum arcu blandit, vehicula magna non, placerat elit. Mauris et pharetratortor. Suspendissea sodales urna. In at augue elit. Vivamus enim nibh, maximus ac felis nec, maximus tempor odio.", Type = "Indoor" });
            Product.Add(new ProductContent() { Title = "The best twenty plant species you can look at at home", Image = "garden_sq_05.jpg", Text = "Aenean interdum arcu blandit, vehicula magna non, placerat elit. Mauris et pharetratortor. Suspendissea sodales urna. In at augue elit. Vivamus enim nibh, maximus ac felis nec, maximus tempor odio.", Type = "Indoor" });
            Product.Add(new ProductContent() { Title = "The best twenty plant species you can look at at home", Image = "garden_sq_06.jpg", Text = "Aenean interdum arcu blandit, vehicula magna non, placerat elit. Mauris et pharetratortor. Suspendissea sodales urna. In at augue elit. Vivamus enim nibh, maximus ac felis nec, maximus tempor odio.", Type = "Indoor" });
            Product.Add(new ProductContent() { Title = "The best twenty plant species you can look at at home", Image = "garden_sq_07.jpg", Text = "Aenean interdum arcu blandit, vehicula magna non, placerat elit. Mauris et pharetratortor. Suspendissea sodales urna. In at augue elit. Vivamus enim nibh, maximus ac felis nec, maximus tempor odio.", Type = "Indoor" });
            Product.Add(new ProductContent() { Title = "The best twenty plant species you can look at at home", Image = "garden_sq_08.jpg", Text = "Aenean interdum arcu blandit, vehicula magna non, placerat elit. Mauris et pharetratortor. Suspendissea sodales urna. In at augue elit. Vivamus enim nibh, maximus ac felis nec, maximus tempor odio.", Type = "Indoor" });



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