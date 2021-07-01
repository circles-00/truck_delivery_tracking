namespace Truck_Delivery_Tracking.Migrations.ApplicationDbContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "firstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "lastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "age", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "pictureURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "pictureURL");
            DropColumn("dbo.AspNetUsers", "age");
            DropColumn("dbo.AspNetUsers", "lastName");
            DropColumn("dbo.AspNetUsers", "firstName");
        }
    }
}
