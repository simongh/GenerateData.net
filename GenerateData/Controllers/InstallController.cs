using System.Web.Mvc;

namespace GenerateData.Controllers
{
	public class InstallController : Controller
	{
		//
		// GET: /Install/
		public ActionResult Index()
		{
			ViewBag.Theme = "classic";

			return View();
		}
	}
}