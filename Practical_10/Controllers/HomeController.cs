using System.Web.Mvc;

namespace Practical_10.Controllers
{
	[Route("Home")]
	public class HomeController : Controller
	{
		[Route("Home/{name}")]
		public ActionResult Index(string name)
		{
			if (!string.IsNullOrEmpty(name))
			{
				ViewBag.Name = name;
			}
			return View();
		}

	}
}