using System.Web;
using System.Web.Optimization;

namespace _60321_2_Severina
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/modernizr-*",
                        "~/Scripts/respond.js",
                        "~/Scripts/jquery.unobtrusive-ajax.js",
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery.validate.unobtrusive.js"));
            bundles.Add(new StyleBundle("~/bundles/styles").Include(
                         "~/Content/bootstrap.css",
                          "~/Content/MySite.css"));
        }
    }
}
