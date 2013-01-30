using System.Web;
using System.Web.Optimization;

namespace MvcValidationExamples
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/noty").Include(
                "~/Scripts/jquery.noty*",
                "~/Scripts/themes/default.js",
                "~/Scripts/layouts/bottom*",
                "~/Scripts/layouts/top*",
                "~/Scripts/layouts/center*",
                "~/Scripts/layouts/inline*"));
        }
    }
}