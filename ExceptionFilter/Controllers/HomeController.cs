using System;
using System.Web.Mvc;

namespace ExceptionFilter.Controllers
{


	public class HomeController : Controller
	{
		[HandleError(ExceptionType = typeof(DivideByZeroException), View = "DivideByZero")]
		public ActionResult Index()
		{
			int a = 0;
			int c = 0;
			int b = c / a;
			ViewBag.b = b;


			return View();
		}


	}
}