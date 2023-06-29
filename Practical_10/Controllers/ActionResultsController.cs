using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.Web.Hosting;
using System.Web.Mvc;

namespace Practical_10.Controllers
{
	public class ActionResultsController : Controller
	{
		public ContentResult ContentResult()
		{
			return Content("<h1>Hello this is Content result</h1>");
		}

		public FileContentResult Downdload()
		{
			var x = HostingEnvironment.ApplicationPhysicalPath;

			string fileContent = System.IO.File.ReadAllText($"{x}/Data/dataToSend.txt");
			byte[] fileBytes = Encoding.UTF8.GetBytes(fileContent);
			string contentType = "text/xml";
			return new FileContentResult(fileBytes, contentType) { FileDownloadName = "Hello.txt" };
		}

		public EmptyResult EmptyResults()
		{
			return new EmptyResult();
		}

		public JavaScriptResult JavaScriptResult()
		{
			var x = HostingEnvironment.ApplicationPhysicalPath;
			string fileContent = System.IO.File.ReadAllText($"{x}/Data/returnJS.js");
			return new JavaScriptResult() { Script = fileContent };
		}

		public JsonResult JsonResult()
		{
			Dictionary<int, string> test = new Dictionary<int, string>();
			test.Add(1, "test");
			test.Add(2, "test1");


			return Json(JsonConvert.SerializeObject(test), "json", JsonRequestBehavior.AllowGet);
		}


	}
}

