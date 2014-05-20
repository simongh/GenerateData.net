using System.Collections.Generic;
using System.Web.Mvc;

namespace GenerateData.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var vm = new ViewModels.Home
			{
				Theme = "classic",
				Languages = new Dictionary<string, string>()
			};

			return View(vm);
		}

		public ActionResult Constants()
		{
			Response.ContentType = "text/javascript";

			return View(new ViewModels.Constants());
		}

		public ActionResult Languages()
		{
			Response.ContentType = "text/javascript";

			return View(new ViewModels.Language());
		}
	}
}