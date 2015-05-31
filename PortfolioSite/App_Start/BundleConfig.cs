using System.Web;
using System.Web.Optimization;

namespace PortfolioSite
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // knockout scripts
            bundles.Add(new ScriptBundle("~/bundles/ko").Include(
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/knockout-mapping-lastest.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/TotallyNG").IncludeDirectory("~/Scripts/Controller", "*.js")
                .Include("~/Scripts/main.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/portCSS").Include("~/Content/bootstrap.min.css",
                "~/Content/stylesheets/main.css",
                "~/Content/stylesheets/about.css",
                "~/Content/stylesheets/blog.css",
                "~/Content/stylesheets/contact.css",
                "~/Content/stylesheets/footer.css",
                "~/Content/stylesheets/header.css",
                "~/Content/stylesheets/media.css",
                "~/Content/stylesheets/media2.css",
                "~/Content/stylesheets/projects.css",
                "~/Content/stylesheets/whatsUp.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
