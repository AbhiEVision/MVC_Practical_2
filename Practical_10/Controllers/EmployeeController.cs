using System.Web.Mvc;

namespace Practical_10.Controllers
{
	//[Route("Employee")]
	public class EmployeeController : Controller
	{
		//[Route("Employee/{name}")]
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