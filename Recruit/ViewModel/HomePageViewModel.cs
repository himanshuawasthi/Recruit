using Recruit.Models;
using System.Collections.Generic;

namespace Recruit.ViewModel
{
    public class HomePageViewModel
    {
        public IEnumerable<Candidates> Candidate { get; set; }
        public IEnumerable<Requisition> Requisitions { get; set; }

        public IEnumerable<Skills> Skill { get; set; }
        public IEnumerable<Scoring_scheme> Scoring_schemes { get; set; }
    }
}