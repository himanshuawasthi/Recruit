using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Recruit.Models;

namespace Recruit.Controllers
{
    public class CandidateController : Controller
    {
        // GET: Candidate


        private ApplicationDbContext _context;

        public CandidateController()
        {
            _context = new ApplicationDbContext();

        }

        public ActionResult AddCandidate()
        {
            return View();
        }
    }
}