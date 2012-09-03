using System.Web.Mvc;
using StructureMap;
using TryCatchFail.LearnStructureMap.Lesson3.Mvc.Services;

namespace TryCatchFail.LearnStructureMap.Lesson3.Mvc.Controllers
{
	public class HomeController : Controller
	{
		private readonly IWelcomeMessageProvider _welcomeMessageProvider;

		public HomeController(IWelcomeMessageProvider welcomeMessageProvider)
		{
			_welcomeMessageProvider = welcomeMessageProvider;
		}

		public ActionResult Index()
		{
			ViewBag.Message = _welcomeMessageProvider.GetWelcomeMessage();

			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your quintessential app description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your quintessential contact page.";

			return View();
		}
	}
}
