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
                "~/Scripts/Framework/Angular/angular-route.min.js",
                "~/Scripts/Framework/Angular/angular-social.js",
                "~/Scripts/Framework/Angular/angular-local-storage.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/App/Module.js",
                "~/Scripts/App/Controllers/Home/Index.js",
                "~/Scripts/App/Controllers/Home/Init.js",
                "~/Scripts/App/Controllers/Shared/Login.js",
                "~/Scripts/App/Services/Shared/Common.js"
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
