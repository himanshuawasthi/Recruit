using Recruit.Models;
using System.Collections.Generic;
using System.Web.Mvc;


namespace Recruit.ViewModel
{
    public class RequisitionPageViewModel
    {
        public IEnumerable<Requisition> Requisitions { get; set; }
        public IEnumerable<Skills> Skill { get; set; }

        public IEnumerable<skill_in_req> skills_in_req { get; set; }

        
    }
}