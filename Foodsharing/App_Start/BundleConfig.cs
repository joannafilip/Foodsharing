using System.Web;
using System.Web.Optimization;

namespace Foodsharing
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/style.css",
                      "~/css/bootstrap.css",
                      "~/css/responsive.css",
                      "~/css/font-awesome.min.css",
                      "~/css/colors.css",
                      "~/css/version/garden.css"
                      ));
            bundles.Add(new StyleBundle("~/Content/profil").Include(
                      "~/css/styleProfil.css"));
            bundles.Add(new StyleBundle("~/Content/login").Include(
                      "~/css/styleLogin.css"));
            bundles.Add(new StyleBundle("~/Content/singleProduct").Include(
                     "~/css/styleProductSinglePage.css"));
            bundles.Add(new StyleBundle("~/Content/signUp").Include(
                     "~/css/styleSignUp.css"));
            bundles.Add(new StyleBundle("~/Content/productsUser").Include(
                   "~/css/styleProductsUser.css"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                      "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/tether").Include(
                 "~/js/tether.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                 "~/js/custom.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/map").Include(
                 "~/js/garden-map.js"));
        }

    }
}
