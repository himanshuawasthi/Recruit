﻿using Recruit.Models;
using Recruit.ViewModel;
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
                    SelectedSkill = context.Skills.ToList().Select(menu => new SelectListItem
                    {
                        Value = menu.Id.ToString(),
                        Text = menu.Name
                    }).ToList()
                };
                obj = mymodel;
            }
            return obj;
        }
        
        public ActionResult Edit()
        {
            return View(FetchModel());
        }

        public ActionResult Add(string key)
        {
            return View();
        
           
        }
    }
}