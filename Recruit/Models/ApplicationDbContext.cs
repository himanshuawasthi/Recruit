using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Recruit.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Candidates> Candidates { get; set; }
        public DbSet<Candidates_details> Candidates_details { get; set; }
        public DbSet<Requisition> Requisition { get; set; }

        public DbSet<Scoring_details> Scoring_details { get; set; }
        public DbSet<Scoring_scheme> Scoring_scheme { get; set; }
        public DbSet<Selection_status> Selection_status { get; set; }

        public DbSet<skill_in_req> skill_in_req { get; set; }
        public DbSet<Skills> Skills { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        
    }

   
}