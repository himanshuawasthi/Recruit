namespace Recruit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReqIdtoRequisitionId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.skill_in_req", "Requisition_Id", "dbo.Requisitions");
            DropIndex("dbo.skill_in_req", new[] { "Requisition_Id" });
            RenameColumn(table: "dbo.skill_in_req", name: "Requisition_Id", newName: "RequisitionId");
            AlterColumn("dbo.skill_in_req", "RequisitionId", c => c.Int(nullable: false));
            CreateIndex("dbo.skill_in_req", "RequisitionId");
            AddForeignKey("dbo.skill_in_req", "RequisitionId", "dbo.Requisitions", "Id", cascadeDelete: true);
            DropColumn("dbo.skill_in_req", "ReqId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.skill_in_req", "ReqId", c => c.Int(nullable: false));
            DropForeignKey("dbo.skill_in_req", "RequisitionId", "dbo.Requisitions");
            DropIndex("dbo.skill_in_req", new[] { "RequisitionId" });
            AlterColumn("dbo.skill_in_req", "RequisitionId", c => c.Int());
            RenameColumn(table: "dbo.skill_in_req", name: "RequisitionId", newName: "Requisition_Id");
            CreateIndex("dbo.skill_in_req", "Requisition_Id");
            AddForeignKey("dbo.skill_in_req", "Requisition_Id", "dbo.Requisitions", "Id");
        }
    }
}
