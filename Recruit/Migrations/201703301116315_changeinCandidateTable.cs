namespace Recruit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeinCandidateTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Candidates", "Requisition_Id", "dbo.Requisitions");
            DropIndex("dbo.Candidates", new[] { "Requisition_Id" });
            RenameColumn(table: "dbo.Candidates", name: "Requisition_Id", newName: "RequisitionId");
            AlterColumn("dbo.Candidates", "RequisitionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Candidates", "RequisitionId");
            AddForeignKey("dbo.Candidates", "RequisitionId", "dbo.Requisitions", "Id", cascadeDelete: true);
            DropColumn("dbo.Candidates", "ReqId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Candidates", "ReqId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Candidates", "RequisitionId", "dbo.Requisitions");
            DropIndex("dbo.Candidates", new[] { "RequisitionId" });
            AlterColumn("dbo.Candidates", "RequisitionId", c => c.Int());
            RenameColumn(table: "dbo.Candidates", name: "RequisitionId", newName: "Requisition_Id");
            CreateIndex("dbo.Candidates", "Requisition_Id");
            AddForeignKey("dbo.Candidates", "Requisition_Id", "dbo.Requisitions", "Id");
        }
    }
}
