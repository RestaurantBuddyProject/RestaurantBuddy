using System.Web;
using System.Web.Optimization;

namespace RestaurantBuddy
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/jquery.mobile-1.4.5.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/jquery.mobile-1.4.5.css",
                      "~/Content/jquery.mobile.theme-1.4.5.css",
                      "~/Content/jquery.mobile.structure-1.4.5.css",
                      "~/Content/bootstrapjquery.mobile.inline-svg-1.4.5.css",
                      "~/Content/jquery.mobile.inline-png-1.4.5.css",
                      "~/Content/jquery.mobile.icons-1.4.5.css",
                      "~/Content/jquery.mobile.external-png-1.4.5.css",
                      "~/Content/font-awesome.css",
                      "~/Content/Override.css",
                      "~/Content/site.css"));
        }
    }
}
