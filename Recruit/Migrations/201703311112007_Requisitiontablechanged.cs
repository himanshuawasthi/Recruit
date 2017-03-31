namespace Recruit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Requisitiontablechanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Requisitions", "reqNo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Requisitions", "reqNo", c => c.String());
        }
    }
}
