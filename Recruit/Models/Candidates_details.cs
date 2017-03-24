
namespace Recruit.Models
{
    public class Candidates_details
    {
        public int Id { get; set; }
        public int RoundId { get; set; }
        public int CandidatesId { get; set; }
        public Candidates Candidates{ get; set; }
        public string Interviewer { get; set; }
        public string Comments { get; set; }
        public int Selection_statusId { get; set; }
        public Selection_status Selection_status { get; set; }
    }
}