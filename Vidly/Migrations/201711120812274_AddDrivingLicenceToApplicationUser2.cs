namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDrivingLicenceToApplicationUser2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DrivingLicence", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.AspNetUsers", "Drivingicence");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Drivingicence", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.AspNetUsers", "DrivingLicence");
        }
    }
}
