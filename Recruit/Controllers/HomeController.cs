using Recruit.Models;
using Recruit.ViewModel;
using System.Linq;
using System.Web.Mvc;

namespace Recruit.Controllers
{
    
    public class HomeController : Controller
    {
        private HomePageViewModel Fetch()
        {
            HomePageViewModel obj = null;
            using (var context = new ApplicationDbContext())
            {
                HomePageViewModel mymodel = new HomePageViewModel
                {
                    Candidate = context.Candidates.ToList(),
                    Requisitions = context.Requisition.ToList(),
                    Skill = context.Skills.ToList(),
                    Scoring_schemes = context.Scoring_scheme.ToList()
                };
                obj = mymodel;

            }
            return obj;
        }
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageSkillsAndRequisition))
            {
                return View("Index", Fetch());
            }
            else
            {
                return View("IndexUser", Fetch());
            }

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