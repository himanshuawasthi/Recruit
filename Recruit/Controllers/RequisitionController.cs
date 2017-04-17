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

        //public ActionResult Add(string key, bool status, string[] skillArray)
        //{
        //    var obj = new Requisition
        //    {
        //        reqNo = key,
        //        Req_status = status,
        //        CreatedDate = DateTime.Now,
                

        //    };
           
            //using (var context = new ApplicationDbContext())
            //{
            //    context.Requisition.Add(obj);
            //    context.SaveChanges();
               
            //}

            //return Json("Success");
           
        
           
        
    }
}