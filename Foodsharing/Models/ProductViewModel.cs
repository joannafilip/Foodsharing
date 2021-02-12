using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foodsharing.Models
{
    public class ProductViewModel
    {
        private List<ProductContent> _product;
        private List<Widget> _recentPost;
        private Widget _titlePost;
        private Widget _instagram;
        private List<Widget> _instagramPhoto;
        private Widget _advertising;
        private List<Widget> _popularCategorie;
        private Widget _categorie;


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

            TitlePost = new Widget();
            TitlePost.Title = "Recent Posts";
            //Recent Posts
            RecentPost = new List<Widget>();
            RecentPost.Add(new Widget() { Image = "garden_sq_09.jpg", UnderTitle = "Beautiful buildings you need to before dying", Date = new DateTime(2020, 1, 1) });
            RecentPost.Add(new Widget() {Image = "garden_sq_06.jpg", UnderTitle = "Let's make an introduction for creative life", Date = new DateTime(2020, 1, 2) });
            RecentPost.Add(new Widget() { Image = "garden_sq_02.jpg", UnderTitle = "Did you see the most beautiful sea in the world?", Date = new DateTime(2020, 1, 3) });

            //Advertising
            Advertising = new Widget();
            Advertising.Image = "banner_04.jpg";
            Advertising.Title = "Advertising";

            //Instagram
            Instagram = new Widget();
            Instagram.Title = "Instagram Feed";
            InstagramPhoto = new List<Widget>();
            InstagramPhoto.Add(new Widget() { Image = "garden_sq_01.jpg" });
            InstagramPhoto.Add(new Widget() { Image = "garden_sq_02.jpg" });
            InstagramPhoto.Add(new Widget() { Image = "garden_sq_03.jpg" });
            InstagramPhoto.Add(new Widget() { Image = "garden_sq_04.jpg" });
            InstagramPhoto.Add(new Widget() { Image = "garden_sq_05.jpg" });
            InstagramPhoto.Add(new Widget() { Image = "garden_sq_06.jpg" });
            InstagramPhoto.Add(new Widget() { Image = "garden_sq_07.jpg" });
            InstagramPhoto.Add(new Widget() { Image = "garden_sq_08.jpg" });
            InstagramPhoto.Add(new Widget() { Image = "garden_sq_09.jpg" });

            //Popular Categories
            Categorie = new Widget();
            Categorie.Title = "Popular Categories";
            PopularCategorie = new List<Widget>();
            PopularCategorie.Add(new Widget() { UnderTitle = "Gardening", Number = 2 });
            PopularCategorie.Add(new Widget() { UnderTitle = "Outdoor Living", Number = 4 });
            PopularCategorie.Add(new Widget() { UnderTitle = "Indoor Living", Number = 22 });
            PopularCategorie.Add(new Widget() { UnderTitle = "Shopping Guides", Number = 19 });
            PopularCategorie.Add(new Widget() { UnderTitle = "Pool Design", Number = 16 });







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
        public List<Widget> PopularCategorie
        {
            get
            {
                return _popularCategorie;
            }

            set
            {
                _popularCategorie = value;
            }
        }
        public Widget Categorie
        {
            get
            {
                return _categorie;
            }

            set
            {
                _categorie = value;
            }
        }
    }
}