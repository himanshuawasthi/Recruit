using Recruit.Models;
using Recruit.ViewModel;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Recruit.Controllers
{
    public class RequisitionController : Controller
    {
        // GET: Requisition

        public RequisitionPageViewModel FetchModel()
        {
            RequisitionPageViewModel obj = null;
            using (var context = new ApplicationDbContext())
            {
                RequisitionPageViewModel mymodel = new RequisitionPageViewModel
                {

                    Requisitions = context.Requisition.ToList(),
                    Skill = context.Skills.ToList(),
                    skills_in_req = context.skill_in_req.ToList(),

                };
                obj = mymodel;
            }
            return obj;
        }

        public ActionResult Edit()
        {
            return View(FetchModel());
        }
        [HttpPost]
        public ActionResult Add(string key, string[] skillArray, bool status)
        {

            return View();
        }

        [HttpPost]
        public ActionResult Edit(string key, string[] skillArray, bool status)
        {

            return View();
        }



    }
}