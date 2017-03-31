using System;
using System.ComponentModel.DataAnnotations;

namespace Recruit.Models
{
    public class Requisition
    {
        public int Id { get; set; }
        [Required]
        public string reqNo { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Req_status { get; set; }
    }
}