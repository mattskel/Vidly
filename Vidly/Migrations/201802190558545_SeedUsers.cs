namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'116ec650-c5b6-43fc-8588-07daa3e9ab34', N'admin@vidly.com', 0, N'ANn0mBI6Vs1DCIT8pgAcHpfrdOh2r3JiyskkXDdBwqz9eUcjFtU/74icrj+OjsN28w==', N'68d76668-8c74-4f01-b6cb-2a09abba88ed', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c41a2354-f5af-4f37-9810-f7cb7f8f7f0f', N'guest@vidly.com', 0, N'AFnkBULgAkmoRF4fjOKE5PlXFD7gIxUVKz6AOkSe+zOttMr8/dh/VnCR9cwQWW6KKQ==', N'616f67a1-3c5a-4656-9411-fc5e2480681f', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8c274c7f-7d09-4dfb-b6d4-81624480d0c0', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'116ec650-c5b6-43fc-8588-07daa3e9ab34', N'8c274c7f-7d09-4dfb-b6d4-81624480d0c0')
");
        }
        
        public override void Down()
        {
        }
    }
}
