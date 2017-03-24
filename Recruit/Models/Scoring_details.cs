
namespace Recruit.Models
{
    public class Scoring_details
    {
        public int Id { get; set; }
        public int RoundId { get; set; }
        public int CandidatesId { get; set; }
        public Candidates Candidates { get; set; }
        public int SkillsId { get; set; }
        public Skills Skills { get; set; }
        public int Scoring_schemeId { get; set; }
        public  Scoring_scheme Scoring_scheme { get; set; }
    }
}