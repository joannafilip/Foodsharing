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