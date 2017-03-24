using System;

namespace Recruit.Models
{
    public class Requisition
    {
        public int Id { get; set; }
        public string reqNo { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Req_status { get; set; }
    }
}