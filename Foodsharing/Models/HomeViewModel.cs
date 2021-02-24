using Foodsharing.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Foodsharing.Models
{
    public class HomeViewModel
    {
        private DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
        private List<MainImageContent> _mainImage;
        private List<ProductContent> _topProduct;
        private List<ContactModel> _contactText;
        public HomeViewModel ()
        {
            //trois images
            MainImage = new List<MainImageContent>();
            MainImage.Add(new MainImageContent() { Image = "4.jpg", Title = "How to Store Vegetables to Keep them Fresh", Date = new DateTime(2021, 1, 1), Autor = "Lucie", Type = "Fruits/Veggies"});
            MainImage.Add(new MainImageContent() { Image = "1.jpg", Title = "The Best Veggie Burger ", Date = new DateTime(2021, 2, 1), Autor = "Frank", Type = "Lunch" });
            MainImage.Add(new MainImageContent() { Image = "2.png", Title = "The Fluffiest Vegan Pancakes", Date = new DateTime(2021, 1, 1), Autor = "Lucie", Type = "Dessert" });

            //top 6 products
            TopProduct = new List<ProductContent>();

            TopProduct.Add(new ProductContent() { Title = "The best twenty plant species you can look at at home", Image = "garden_sq_01.jpg", Text = "Aenean interdum arcu blandit, vehicula magna non, placerat elit. Mauris et pharetratortor. Suspendissea sodales urna. In at augue elit. Vivamus enim nibh, maximus ac felis nec, maximus tempor odio.", Type = "Indoor" });
            TopProduct.Add(new ProductContent() { Title = "The best twenty plant species you can look at at home", Image = "garden_sq_02.jpg", Text = "Aenean interdum arcu blandit, vehicula magna non, placerat elit. Mauris et pharetratortor. Suspendissea sodales urna. In at augue elit. Vivamus enim nibh, maximus ac felis nec, maximus tempor odio.", Type = "Indoor" });
            TopProduct.Add(new ProductContent() { Title = "The best twenty plant species you can look at at home", Image = "garden_sq_03.jpg", Text = "Aenean interdum arcu blandit, vehicula magna non, placerat elit. Mauris et pharetratortor. Suspendissea sodales urna. In at augue elit. Vivamus enim nibh, maximus ac felis nec, maximus tempor odio.", Type = "Indoor" });
            TopProduct.Add(new ProductContent() { Title = "The best twenty plant species you can look at at home", Image = "garden_sq_04.jpg", Text = "Aenean interdum arcu blandit, vehicula magna non, placerat elit. Mauris et pharetratortor. Suspendissea sodales urna. In at augue elit. Vivamus enim nibh, maximus ac felis nec, maximus tempor odio.", Type = "Indoor" });
            TopProduct.Add(new ProductContent() { Title = "The best twenty plant species you can look at at home", Image = "garden_sq_05.jpg", Text = "Aenean interdum arcu blandit, vehicula magna non, placerat elit. Mauris et pharetratortor. Suspendissea sodales urna. In at augue elit. Vivamus enim nibh, maximus ac felis nec, maximus tempor odio.", Type = "Indoor" });
            TopProduct.Add(new ProductContent() { Title = "The best twenty plant species you can look at at home", Image = "garden_sq_06.jpg", Text = "Aenean interdum arcu blandit, vehicula magna non, placerat elit. Mauris et pharetratortor. Suspendissea sodales urna. In at augue elit. Vivamus enim nibh, maximus ac felis nec, maximus tempor odio.", Type = "Indoor" });

            //page contact
            ContactText = new List<ContactModel>();
            ContactText.Add(new ContactModel() { Title = "Who we are", Text = "It is an online platform that saves and distributes surplus food."});
            ContactText.Add(new ContactModel() { Title = "How we help?", Text = "Every year, a third of global food production goes to waste according to studies done by the United Nations Food and Agricultural Organization (FAO). In the spirit of “think global, act local”, the grassroots initiative Foodsharing was founded in Germany in 2012 to tackle the problem of food waste."});
            ContactText.Add(new ContactModel() { Title = "The beginning", Text = "The beginnings of the initiative can be traced to two German cities, Cologne and Berlin, in 2012. In Cologne the online - platform “foodsharing.de” was invented to allow private individuals to share still edible food which they would otherwise throw away"});


        }

        public List<MainImageContent> MainImage
        {
            get
            {
                return _mainImage;
            }

            set
            {
                _mainImage= value;
            }
        }
        public List<ProductContent> TopProduct
        {
            get
            {
                return _topProduct;
            }

            set
            {
                _topProduct = value;
            }
        }
        public List<ContactModel> ContactText
        {
            get
            {
                return _contactText;
            }

            set
            {
                _contactText = value;
            }
        }

    }
}