﻿using System.Web;
using System.Web.Optimization;

namespace LY.MVCOA.Project
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //jquery,jquery validate, jquery form
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryfrom").Include(
                       "~/Scripts/jquery.form.js"));


            //bundle customer define 
            bundles.Add(new ScriptBundle("~/bundles/common").Include(
                        "~/Scripts/common.js"));

            bundles.Add(new ScriptBundle("~/bundles/home").Include(
                       "~/Scripts/home.js"));
            bundles.Add(new ScriptBundle("~/bundles/account").Include(
                       "~/Scripts/Account.js"));

            //easyui
            bundles.Add(new ScriptBundle("~/bundles/easyuiplus").Include(
                       "~/Scripts/jquery.easyui.plus.js"));

            bundles.Add(new StyleBundle("~/Content/themes/blue/css").Include("~/Content/themes/blue/easyui.css"));
            bundles.Add(new StyleBundle("~/Content/themes/gray/css").Include("~/Content/themes/gray/easyui.css"));
            bundles.Add(new StyleBundle("~/Content/themes/metro/css").Include("~/Content/themes/metro/easyui.css"));


            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
