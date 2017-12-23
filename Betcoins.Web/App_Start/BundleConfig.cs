using System.Web.Optimization;

namespace Betcoins.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/framework").Include(
                "~/Scripts/Framework/respond.min.js",
                "~/Scripts/Framework/Angular/angular.min.js",
                "~/Scripts/Framework/Angular/angular-mocks.js",
                "~/Scripts/Framework/Angular/angular-route.min.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/App/Module.js",
                "~/Scripts/App/Controllers/Home/index.js",
                "~/Scripts/App/Controllers/Home/init.js"
            ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/Framework/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));
        }
    }
}
