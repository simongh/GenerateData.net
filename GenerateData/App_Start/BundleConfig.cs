using System.Web.Optimization;

namespace GenerateData
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("/bundles/codemirror").Include(
				"~/scripts/codemirror/codemirror.js"));

			bundles.Add(new ScriptBundle("~/bundles/shared").Include(
				"~/scripts/libs/jquery-{version}.js",
				"~/scripts/libs/jquery-ui-{version}.js",
				"~/scripts/libs/jquery.json-2.2.min.js",
				"~/scripts/libs/chosen.jquery.js"));

			bundles.Add(new ScriptBundle("~/bundles/ie").Include(
				"~/scripts/libs/html5shiv.js",
				"~/scripts/libs/excanvas.js"));

			bundles.Add(new ScriptBundle("~/bundles/spinners").Include(
				"~/scripts/libs/spinners.js"));

			bundles.Add(new StyleBundle("~/content/index").Include(
				"~/content/chosen.css",
				"~/content/tablesorter.theme.css"));

			bundles.Add(new StyleBundle("~/content/smoothness/").Include(
				"~/content/smoothness/jquery-ui-min.css"));

			bundles.Add(new StyleBundle("/script/codemirror/lib").Include(
				"~/scripts/codemirror/lib/codemirror.css"));

			bundles.Add(new StyleBundle("~/content/themes/classic/compiled").Include(
				"~/content/themes/classic/compiled/styles.css"));
		}
	}
}
