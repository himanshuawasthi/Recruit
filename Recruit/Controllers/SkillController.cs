using Recruit.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Recruit.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        public ActionResult EditSkill()
        {
            List<Skills> obj;
            using(var context = new ApplicationDbContext())
            {
                obj = context.Skills.ToList();
            }
            return View(obj);
        }
    }
}