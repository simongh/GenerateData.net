using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GenerateData.Helpers
{
	public static class LanguageDropDownExtensions
	{
		public static HtmlString LanguageDropDown(this HtmlHelper htmlhelper)
		{
			return LanguageDropDownHelper(htmlhelper, new Dictionary<string, string>(), null, "", false);
		}

		public static HtmlString LanguageDropDown(this HtmlHelper htmlhelper, object arguments)
		{
			return LanguageDropDown(htmlhelper, new RouteValueDictionary(arguments));
		}

		public static HtmlString LanguageDropDown(this HtmlHelper htmlhelper, RouteValueDictionary arguments)
		{
			var langs = arguments.ContainsKey("languages") ? (Dictionary<string, string>)arguments["languages"] : new Dictionary<string, string>();
			var id = arguments.ContainsKey("id") ? (string)arguments["id"] : null;
			var selectedLang = arguments.ContainsKey("selectedLanguage") ? (string)arguments["selectedLanguage"] : "";
			var disabled = arguments.ContainsKey("isDisabled") ? (bool)arguments["isDisabled"] : false;

			return LanguageDropDownHelper(htmlhelper, langs, id, selectedLang, disabled);
		}

		private static HtmlString LanguageDropDownHelper(HtmlHelper htmlHelper, IDictionary<string, string> languages, string id, string selectedLanguage, bool isDisabled)
		{
			var tb = new TagBuilder("select");

			if (!string.IsNullOrEmpty(id))
				tb.Attributes.Add("id", id);

			if (isDisabled)
				tb.Attributes.Add("disabled", "disabled");

			var ib = new TagBuilder("option");
			ib.Attributes.Add("value", "");
			ib.InnerHtml = Resources.Strings.SelectLanguage;

			tb.InnerHtml = ib.ToString();

			foreach (var item in languages)
			{
				ib = new TagBuilder("option");
				ib.Attributes.Add("value", item.Key);
				if (item.Key.Equals(selectedLanguage, StringComparison.InvariantCultureIgnoreCase))
					ib.Attributes.Add("selected", "selected");
				ib.InnerHtml = item.Value;

				tb.InnerHtml += ib.ToString();
			}

			return new HtmlString(tb.ToString());
		}
	}
}