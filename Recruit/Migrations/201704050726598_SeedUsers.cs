namespace Recruit.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@" INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4dea987c-e17b-4be2-8294-7b68f5eaf473', N'Basant_Ray@Dell.com', 0, N'AFnbfItqPSdDpRDAsHtQtvCbUUIr7T03riIADfLHSV27kX1N3TFplWuqN0ilI4Okng==', N'e076b401-bd34-43ac-8fb4-c571cb692bb4', NULL, 0, 0, NULL, 1, 0, N'Basant_Ray@Dell.com')
                   INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'969a0b2e-b4bb-4204-9e93-f881dcdd6364', N'Nagaraj_Desai@Dell.com', 0, N'ADEkwUenGlheyvAF3+JhuJ2KTqUXahy3/OEmc8FS3NNNUzksSQfoLBD1QxufdbMksA==', N'3bf73b15-e6dd-4fc0-9277-35e279569349', NULL, 0, 0, NULL, 1, 0, N'Nagaraj_Desai@Dell.com')
                   INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b010b3f8-45f6-48b8-8f69-a0ea7cf1d31b', N'Himanshu_Awasthi@Dell.com', 0, N'ALP6SfNuIl1Km/iv+qWHKW9iuWHlIhWiBkAIM44x/Ou1dS9/acMJMZ5MB2y19iDR4A==', N'e98255ee-f86a-433b-a668-902dec54ff30', NULL, 0, 0, NULL, 1, 0, N'Himanshu_Awasthi@Dell.com')
                   INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fd582f2d-bbdf-4fd0-a217-012fbd121260', N'sakshikhandelwal1312@gmail.com', 0, N'ABgQ0QvIwWREKKSYznSyE059lTU5q2UQxIVHk5l94NL57iR0nM/YNS5MEqfu57Ehwg==', N'35e8055f-fca8-4986-9a21-0c12cf91caf9', NULL, 0, 0, NULL, 1, 0, N'sakshikhandelwal1312@gmail.com')
                   INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e00e7891-c6d7-4a70-8758-3604b001d311', N'CanManageSkillsAndRequisition')
                   INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4dea987c-e17b-4be2-8294-7b68f5eaf473', N'e00e7891-c6d7-4a70-8758-3604b001d311')
                   INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'969a0b2e-b4bb-4204-9e93-f881dcdd6364', N'e00e7891-c6d7-4a70-8758-3604b001d311')
                   INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b010b3f8-45f6-48b8-8f69-a0ea7cf1d31b', N'e00e7891-c6d7-4a70-8758-3604b001d311')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
