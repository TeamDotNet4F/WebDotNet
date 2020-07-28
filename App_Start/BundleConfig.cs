using System.Web;
using System.Web.Optimization;

namespace Project
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/OwlCarouselCss").Include(
                  "~/Content/plugins/OwlCarousel2-2.2.1/animate.css",
                  "~/Content/plugins/OwlCarousel2-2.2.1/owl.carousel.css",
                  "~/Content/plugins/OwlCarousel2-2.2.1/owl.theme.default.css"));
            bundles.Add(new StyleBundle("~/Content/BlogCss").Include(
                  "~/Content/styles/blog_responsive.css",
                  "~/Content/styles/blog_single_responsive.css",
                  "~/Content/styles/blog_single_styles.css",
                  "~/Content/styles/blog_styless.css"));
            bundles.Add(new StyleBundle("~/Content/fontawesome").Include(
                      "~/Content/plugins/fontawesome-free-5.0.1/css/fontawesome-all.css"));
            bundles.Add(new StyleBundle("~/Content/slick").Include(
                      "~/Content/plugins/slick-1.8.0/slick.css"));
            bundles.Add(new StyleBundle("~/Content/indexcss").Include(
                  "~/Content/styles/main_styles.css",
                  "~/Content/styles/responsive.css"));
            bundles.Add(new ScriptBundle("~/bundles/greensock").Include(
                      "~/Content/plugins/greensock/animation.gsap.min.js",
                      "~/Content/plugins/greensock/ScrollToPlugin.min.js",
                      "~/Content/plugins/greensock/TimelineMax.min.js",
                      "~/Content/plugins/greensock/TweenMax.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/scrollmagic").Include(
                      "~/Content/plugins/scrollmagic/ScrollMagic.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/parallax").Include(
                      "~/Content/plugins/parallax-js-master/parallax.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/easing").Include(
                      "~/Content/plugins/easing/easing.js"));
            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                      "~/Content/plugins/customJS/blog_custom.js",
                      "~/Content/plugins/customJS/blog_single_custom.js"));
            bundles.Add(new ScriptBundle("~/bundles/slickjs").Include(
                      "~/Content/plugins/slick-1.8.0/slick.js"));
        bundles.Add(new ScriptBundle("~/bundles/OwlCarouseljs").Include(
                   "~/Content/plugins/OwlCarousel2-2.2.1/owl.carousel.js"));

            BundleTable.EnableOptimizations = false;
        }
    }
}
