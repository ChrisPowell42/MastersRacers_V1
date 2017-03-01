﻿using System.Web;
using System.Web.Optimization;

namespace MastersRacers
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css",
                      "~/Content/angular-material.css"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                      "~/Scripts/angular.js",
                      "~/Scripts/angular-animate.js",
                      "~/Scripts/angular-aria.js",
                      "~/Scripts/angular-messages.js",
                      "~/Scripts/angular-material/angular-material.js"));

            bundles.Add(new ScriptBundle("~/bundles/MastersRacersServices").Include(
                      "~/Scripts/app/module-racerApp.js",
                      "~/Scripts/app/services/refDataService.js",
                      "~/Scripts/app/services/locationService.js",
                      "~/Scripts/app/services/seasonService.js",
                      "~/Scripts/app/services/raceEventService.js",
                      "~/Scripts/app/services/racerService.js"));

            bundles.Add(new ScriptBundle("~/bundles/MastersRacersControllers").Include(
                      "~/Scripts/app/controllers/mainTabController.js"));

            bundles.Add(new ScriptBundle("~/bundles/MastersRacers").Include(
                      "~/Scripts/app/components/seasonList.js",
                      "~/Scripts/app/components/seasonListItem.js",
                      "~/Scripts/app/components/racerList.js",
                      "~/Scripts/app/components/racerListItem.js",
                      "~/Scripts/app/components/modifyRacer.js",
                      "~/Scripts/app/components/locationListItem.js",
                      "~/Scripts/app/components/locationList.js",
                      "~/Scripts/app/components/modifyLocation.js",
                      "~/Scripts/app/components/raceEventList.js",
                      "~/Scripts/app/components/raceEventListItem.js",
                      "~/Scripts/app/components/modifyRaceEvent.js"));
        }
    }
}
