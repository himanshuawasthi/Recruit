using System;
using System.ComponentModel.DataAnnotations;

namespace Recruit.Models
{
    public class Candidates
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public int RequisitionId { get; set; }
        public Requisition Requisition { get; set; }
    }
}