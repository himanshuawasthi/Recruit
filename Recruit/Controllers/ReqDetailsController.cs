using Recruit.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Recruit.Controllers
{
    public class ReqDetailsController : Controller
    {
        // GET: ReqDetails
        public ActionResult Add()
        {
            List<Skills> obj;
            using (var context = new ApplicationDbContext())
            {
                obj = context.Skills.ToList();
            }
            return View(obj);
            
        }
    }
}