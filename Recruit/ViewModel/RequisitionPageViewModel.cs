using Recruit.Models;
using System.Collections.Generic;
using System.Web.Mvc;


namespace Recruit.ViewModel
{
    public class RequisitionPageViewModel
    {
        public List<Requisition> Requisitions { get; set; }
        public List<Skills> Skill { get; set; }

        public List<skill_in_req> skills_in_req { get; set; }

        public List<SelectListItem> SelectedSkill { get; set; }
    }
}