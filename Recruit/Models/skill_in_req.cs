
namespace Recruit.Models
{
    public class skill_in_req
    {
        public int Id { get; set; }
        public int SkillsId { get; set; }
        public Skills Skills { get; set; }
        public int ReqId { get; set; }
        public Requisition Requisition { get; set; }
    }
}