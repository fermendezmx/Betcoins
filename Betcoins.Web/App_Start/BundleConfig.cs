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
                "~/Scripts/Framework/Auth0/auth0.js",
                "~/Scripts/Framework/Auth0/lock.js",
                "~/Scripts/Framework/Angular/angular.min.js",
                "~/Scripts/Framework/Angular/angular-mocks.js",
                "~/Scripts/Framework/Angular/angular-route.min.js",
                "~/Scripts/Framework/Angular/angular-lock.js",
                "~/Scripts/Framework/Angular/angular-storage.js",
                "~/Scripts/Framework/Angular/angular-jwt.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/App/Module.js",
                "~/Scripts/App/Controllers/Home/Index.js",
                "~/Scripts/App/Controllers/Home/Init.js",
                "~/Scripts/App/Controllers/Shared/Login.js",
                "~/Scripts/App/Services/Shared/Common.js",
                "~/Scripts/App/Services/Shared/Auth0.js",
                "~/Scripts/App/Services/Account.js"
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
