using System;
using System.Web.Mvc;

namespace OutputCacheTest.Controllers
{
	public class HomeController : Controller
	{
		[OutputCache(Duration = 300, Location = System.Web.UI.OutputCacheLocation.ServerAndClient)]
		public ActionResult Index()
		{
			ViewBag.Data = DateTime.Now.ToString();
			return View();
		}


	}
}