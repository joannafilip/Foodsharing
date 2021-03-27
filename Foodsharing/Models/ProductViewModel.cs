using Foodsharing.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Foodsharing.Models
{
    public class ProductViewModel
    {
        private DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
        private List<ProductContent> _product;
        private List<Widget> _recentPost;
        private Widget _titlePost;
        private Widget _instagram;
        private List<Widget> _instagramPhoto;
        private Widget _advertising;
        private List<Widget> _popularCategorie;
        private Widget _categorie;
        private ProductContent _targetProduct;
        private int _maxProduct, _maxPage;


        public void paginateProduct(int page = 1, string searchString = null, string type = "", string sortOrder = "")
        {
           
            Product = ctx.GetProductModelByPage(page, searchString, type, sortOrder);
            if (searchString != null || type != "")
            {
                MaxProduct = ctx.CountProductsAllPage(page, searchString, type, sortOrder);
                if ((MaxProduct % 3) == 0)
                {
                    MaxPage = MaxProduct / 3;
                }
                else
                {
                    double nbPage = MaxProduct / 3;
                    MaxPage = (int)Math.Floor(nbPage) + 1;
                }
            }


        }
        public ProductViewModel()
        {

            MaxProduct = ctx.CountProducts();
            if ((MaxProduct % 3) == 0)
            {
                MaxPage = MaxProduct / 3;
            }
            else
            {
                double nbPage = MaxProduct / 3;
                MaxPage = (int)Math.Floor(nbPage) + 1;
            }

            Product = ctx.GetPropositionsProducts();
            TitlePost = new Widget();
            TitlePost.Title = "Recent Posts";
            //Recent Posts
            RecentPost = new List<Widget>();
            RecentPost.Add(new Widget() { Image = "a1.jpg", UnderTitle = "The Problem of Food Waste", Date = new DateTime(2021, 3, 1) });
            RecentPost.Add(new Widget() {Image = "a2.jpg", UnderTitle = "People waste more food than they think", Date = new DateTime(2021, 2, 2) });
            RecentPost.Add(new Widget() { Image = "a3.jpg", UnderTitle = "Reducing Wasted Food At Home", Date = new DateTime(2021, 1, 30) });

            //Advertising
            Advertising = new Widget();
            Advertising.Image = "ad.jpg";
            Advertising.Title = "Advertising";

            //Instagram
            Instagram = new Widget();
            Instagram.Title = "Instagram Feed";
            InstagramPhoto = new List<Widget>();
            InstagramPhoto.Add(new Widget() { Image = "i1.jpg" });
            InstagramPhoto.Add(new Widget() { Image = "i2.jpg" });
            InstagramPhoto.Add(new Widget() { Image = "i3.jpg" });
            InstagramPhoto.Add(new Widget() { Image = "i4.jpg" });
            InstagramPhoto.Add(new Widget() { Image = "i5.jpg" });
            InstagramPhoto.Add(new Widget() { Image = "i6.jpg" });
            InstagramPhoto.Add(new Widget() { Image = "i7.jpg" });
            InstagramPhoto.Add(new Widget() { Image = "i8.jpg" });
            InstagramPhoto.Add(new Widget() { Image = "i9.jpg" });

            //Popular Categories
            PopularCategorie = ctx.GetAllTypes();
            foreach (Widget item in PopularCategorie)
            {
                item.Number= ctx.CountProductByType(item.UnderTitle);
            }
            Categorie = new Widget();
            Categorie.Title = "Popular Categories";
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
        public ProductContent TargetProduct
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
        public int MaxProduct
        {
            get
            {
                return _maxProduct;
            }

            set
            {
                _maxProduct = value;
            }
        }
        public int MaxPage
        {
            get
            {
                return _maxPage;
            }

            set
            {
                _maxPage = value;
            }
        }
       



    }

}