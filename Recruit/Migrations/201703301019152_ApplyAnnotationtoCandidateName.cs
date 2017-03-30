namespace Recruit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationtoCandidateName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Candidates", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Candidates", "Name", c => c.String());
        }
    }
}
