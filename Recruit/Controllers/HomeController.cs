using System.Web.Mvc;

namespace Recruit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //public ActionResult Edit()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return RedirectToAction("Edit", "Requisition");
        //}

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}