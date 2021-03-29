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
        private Widget _instagram;
        private List<Widget> _instagramPhoto;
        private Widget _advertising;
        private List<Widget> _recentPost;
        private Widget _titlePost;
        public HomeViewModel ()
        {
            //trois images
            MainImage = new List<MainImageContent>();
            MainImage.Add(new MainImageContent() { Image = "4.jpg", Title = "How to Store Vegetables to Keep them Fresh", Date = new DateTime(2021, 1, 1), Autor = "Lucie", Type = "Fruits/Veggies"});
            MainImage.Add(new MainImageContent() { Image = "1.jpg", Title = "The Best Veggie Burger ", Date = new DateTime(2021, 2, 1), Autor = "Frank", Type = "Lunch" });
            MainImage.Add(new MainImageContent() { Image = "2.png", Title = "The Fluffiest Vegan Pancakes", Date = new DateTime(2021, 1, 1), Autor = "Lucie", Type = "Dessert" });

            //top 6 products
            TopProduct = ctx.GetSixLatestProducts();

            //page contact
            ContactText = new List<ContactModel>();
            ContactText.Add(new ContactModel() { Title = "Who we are", Text = "It is an online platform that saves and distributes surplus food."});
            ContactText.Add(new ContactModel() { Title = "How we help?", Text = "Every year, a third of global food production goes to waste according to studies done by the United Nations Food and Agricultural Organization (FAO). In the spirit of “think global, act local”, the grassroots initiative Foodsharing was founded in Germany in 2012 to tackle the problem of food waste."});
            ContactText.Add(new ContactModel() { Title = "The beginning", Text = "The beginnings of the initiative can be traced to two German cities, Cologne and Berlin, in 2012. In Cologne the online - platform “foodsharing.de” was invented to allow private individuals to share still edible food which they would otherwise throw away"});

            TitlePost = new Widget();
            TitlePost.Title = "Recent Posts";
            //Recent Posts
            RecentPost = new List<Widget>();
            RecentPost.Add(new Widget() { Image = "a1.jpg", UnderTitle = "The Problem of Food Waste", Date = new DateTime(2021, 3, 1) });
            RecentPost.Add(new Widget() { Image = "a2.jpg", UnderTitle = "People waste more food than they think", Date = new DateTime(2021, 2, 2) });
            RecentPost.Add(new Widget() { Image = "a3.jpg", UnderTitle = "Reducing Wasted Food At Home", Date = new DateTime(2021, 1, 30) });

            //Advertising
            Advertising = new Widget();
            Advertising.Image = "ad.jpg";
            Advertising.Title = "Advertising";

            //Instagram
            Instagram = new Widget();
            Instagram.Title = "Instagram Feed";
            InstagramPhoto = new List<Widget>();

            for (int i = 1; i < 10; i++)
            {
                InstagramPhoto.Add(new Widget() { Image = "i" + i + ".jpg" });
            }

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
        public Widget Instagram
        {
            get
            {
                return _instagram;
            }

            set
            {
                _instagram = value;
            }
        }
        public List<Widget> InstagramPhoto
        {
            get
            {
                return _instagramPhoto;
            }

            set
            {
                _instagramPhoto = value;
            }
        }
        public Widget Advertising
        {
            get
            {
                return _advertising;
            }

            set
            {
                _advertising = value;
            }
        }
        public List<Widget> RecentPost
        {
            get
            {
                return _recentPost;
            }

            set
            {
                _recentPost = value;
            }
        }
        public Widget TitlePost
        {
            get
            {
                return _titlePost;
            }

            set
            {
                _titlePost = value;
            }
        }
    }
}