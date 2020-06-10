using System.Web;
using System.Web.Optimization;

namespace TempProject
{
    public class BundleConfig
    {
        // 如需「搭配」的詳細資訊，請瀏覽 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            ////1
            bundles.Add(new ScriptBundle("~/bundles/vendor/jquery").Include(
                        "~/Content/vendor/jquery/jquery.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                        "~/Content/vendor/bootstrap/js/bootstrap.bundle.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-easing").Include(
                        "~/Content/vendor/jquery-easing/jquery.easing.js"));
            bundles.Add(new ScriptBundle("~/bundles/js/sb").Include(
                        "~/Content/js/sb-admin-2.js"));
            ////1
            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好實際執行時，請使用 http://modernizr.com 上的建置工具，只選擇您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            ///1
            bundles.Add(new StyleBundle("~/Content/css/free").Include(
                      "~/Content/vendor/fontawesome-free/css/all.css",
                      "~/Content/css/sb-admin-2.css"));
            ////1
            //沒有壓縮過的CSS
            BundleTable.EnableOptimizations = false ;

            ////2
            //bundles.Add(new StyleBundle("~/Content/css/freeTwo1").Include(
            //         "~/Content/assets/vendor/nucleo/css/nucleo.css"));
            //bundles.Add(new StyleBundle("~/Content/css/freeTwo2").Include(
            //         "~/Content/assets/vendor/fortawesome/fontawesome-free/css/all.min.css"));
            //bundles.Add(new StyleBundle("~/Content/css/freeTwo3").Include(
            //         "~/Content/assets/css/argon.css"));
            ////2

        }
    }
}
