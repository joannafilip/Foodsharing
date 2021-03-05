using Foodsharing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foodsharing.Infra
{
    public class SessionUtils
    {
        public static bool IsLogged
        {
            get
            {
                if (HttpContext.Current.Session["logged"] == null)
                {
                    HttpContext.Current.Session["logged"] = false;
                }
                return (bool)HttpContext.Current.Session["logged"];
            }
            
            set
            {
                HttpContext.Current.Session["logged"] = value;
            }
        }
        public static ProfilModel ConnectedUser
        {
            get
            {
                return (ProfilModel)HttpContext.Current.Session["ConnectedUser"];
            }

            set { HttpContext.Current.Session["ConnectedUser"] = value; }

        }
        public static SignUpModel EnregisteredUser
        {
            get
            {
                return (SignUpModel)HttpContext.Current.Session["EnregisteredUser"];
            }

            set { HttpContext.Current.Session["EnregisteredUser"] = value; }

        }
    }
}