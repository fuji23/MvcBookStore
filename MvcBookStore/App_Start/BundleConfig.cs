using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace MvcBookStore.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles) 
        {
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/css/*.css"));
        }
    }
}