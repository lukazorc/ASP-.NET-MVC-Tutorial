namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'57b45ec7-158f-456a-a08c-4a0b625eb193', N'guest@vidly.com', 0, N'ALU8oEkuKrF5OksXsqBwJiMsp38BchVfiNB8Eq3R4YQF7wv7bk0cmlxki5JoB16Vlg==', N'52d24a07-20f4-42ba-abd0-ae54aeac50fd', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6b21cf65-e447-42a7-894e-d0036610d4ce', N'admin@vidly.com', 0, N'AH7SPJnClQJVkeGalLA+B78P0CKc8FMWp/rpQwRUwpfCSF5RQsmxT+0ciwVxiRltcw==', N'e1532c58-3672-474b-8339-432ef67bf098', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'70605660-5ffe-4ab5-a105-d8909abe992e', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6b21cf65-e447-42a7-894e-d0036610d4ce', N'70605660-5ffe-4ab5-a105-d8909abe992e')

");
        }

        public override void Down()
        {
        }
    }
}
