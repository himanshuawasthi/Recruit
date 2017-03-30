namespace Recruit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateRequisitions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Contact = c.String(),
                        Email = c.String(),
                        ReqId = c.Int(nullable: false),
                        Requisition_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Requisitions", t => t.Requisition_Id)
                .Index(t => t.Requisition_Id);
            
            CreateTable(
                "dbo.Requisitions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        reqNo = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        Req_status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Candidates_details",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoundId = c.Int(nullable: false),
                        CandidatesId = c.Int(nullable: false),
                        Interviewer = c.String(),
                        Comments = c.String(),
                        Selection_statusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.CandidatesId, cascadeDelete: true)
                .ForeignKey("dbo.Selection_status", t => t.Selection_statusId, cascadeDelete: true)
                .Index(t => t.CandidatesId)
                .Index(t => t.Selection_statusId);
            
            CreateTable(
                "dbo.Selection_status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Scoring_details",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoundId = c.Int(nullable: false),
                        CandidatesId = c.Int(nullable: false),
                        SkillsId = c.Int(nullable: false),
                        Scoring_schemeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidates", t => t.CandidatesId, cascadeDelete: true)
                .ForeignKey("dbo.Scoring_scheme", t => t.Scoring_schemeId, cascadeDelete: true)
                .ForeignKey("dbo.Skills", t => t.SkillsId, cascadeDelete: true)
                .Index(t => t.CandidatesId)
                .Index(t => t.SkillsId)
                .Index(t => t.Scoring_schemeId);
            
            CreateTable(
                "dbo.Scoring_scheme",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ScorePattern = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.skill_in_req",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SkillsId = c.Int(nullable: false),
                        ReqId = c.Int(nullable: false),
                        Requisition_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Requisitions", t => t.Requisition_Id)
                .ForeignKey("dbo.Skills", t => t.SkillsId, cascadeDelete: true)
                .Index(t => t.SkillsId)
                .Index(t => t.Requisition_Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.skill_in_req", "SkillsId", "dbo.Skills");
            DropForeignKey("dbo.skill_in_req", "Requisition_Id", "dbo.Requisitions");
            DropForeignKey("dbo.Scoring_details", "SkillsId", "dbo.Skills");
            DropForeignKey("dbo.Scoring_details", "Scoring_schemeId", "dbo.Scoring_scheme");
            DropForeignKey("dbo.Scoring_details", "CandidatesId", "dbo.Candidates");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Candidates_details", "Selection_statusId", "dbo.Selection_status");
            DropForeignKey("dbo.Candidates_details", "CandidatesId", "dbo.Candidates");
            DropForeignKey("dbo.Candidates", "Requisition_Id", "dbo.Requisitions");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.skill_in_req", new[] { "Requisition_Id" });
            DropIndex("dbo.skill_in_req", new[] { "SkillsId" });
            DropIndex("dbo.Scoring_details", new[] { "Scoring_schemeId" });
            DropIndex("dbo.Scoring_details", new[] { "SkillsId" });
            DropIndex("dbo.Scoring_details", new[] { "CandidatesId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Candidates_details", new[] { "Selection_statusId" });
            DropIndex("dbo.Candidates_details", new[] { "CandidatesId" });
            DropIndex("dbo.Candidates", new[] { "Requisition_Id" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.skill_in_req");
            DropTable("dbo.Skills");
            DropTable("dbo.Scoring_scheme");
            DropTable("dbo.Scoring_details");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Selection_status");
            DropTable("dbo.Candidates_details");
            DropTable("dbo.Requisitions");
            DropTable("dbo.Candidates");
        }
    }
}
