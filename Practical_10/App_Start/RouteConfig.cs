using System.Web.Mvc;
using System.Web.Routing;

namespace Practical_10
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Employee",
				url: "Employee/{name}",
				defaults: new { controller = "Employee", action = "Index" }
			);


			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Employee", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
