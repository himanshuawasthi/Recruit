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

        [HttpPost]
        public ActionResult EditSkill(int key)
        {
            List<Skills> objs;
            using(var context = new ApplicationDbContext())
            {
                var obj = context.Skills.Where(m => m.Id == key).FirstOrDefault();
                context.Skills.Remove(obj);
                context.SaveChanges();
                objs = context.Skills.ToList();
            }
            return RedirectToAction("EditSkill");
        }

        public ActionResult Add(string Skill)
        {
            var obj = new Skills
            {
                Name = Skill
            };
            List<Skills> newObj = null;
            using (var context = new ApplicationDbContext())
            {
                context.Skills.Add(obj);
                context.SaveChanges();
                newObj = context.Skills.ToList();
            }

            return RedirectToAction("EditSkill");
        }
    }
}