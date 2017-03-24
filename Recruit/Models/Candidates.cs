using System;

namespace Recruit.Models
{
    public class Candidates
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public int ReqId { get; set; }
        public Requisition Requisition { get; set; }
    }
}