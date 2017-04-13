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
            using (var context = new ApplicationDbContext())
            {
                obj = context.Skills.ToList();
            }
            return View(obj);
        }

        [HttpPost]
        public ActionResult EditSkill(int key)
        {
            List<Skills> objs;
            using (var context = new ApplicationDbContext())
            {
                var obj = context.Skills.Where(m => m.Id == key).FirstOrDefault();
                context.Skills.Remove(obj);
                context.SaveChanges();
                objs = context.Skills.ToList();
            }
            return Json(objs, "Success");
        }

    
        public ActionResult Add(string key)
        {
            var obj = new Skills
            {
                Name = key
            };
            List<Skills> newObj = null;
            using (var context = new ApplicationDbContext())
            {
                context.Skills.Add(obj);
                context.SaveChanges();
                newObj = context.Skills.ToList();
            }

            return Json(newObj, "Success");
        }

        public ActionResult Update(string key, string oldVal)
        {
            var obj = new Skills
            {
                Name = key
            };
            using (var context = new ApplicationDbContext())
            {
                obj = context.Skills.Where(m => m.Name == oldVal).FirstOrDefault();
                obj.Name = key;
                var entry = context.Entry(obj);
                entry.Property(e => e.Name).IsModified = true;
                context.SaveChanges();
            }
            return Json(obj , "Success");
        }
    }
}