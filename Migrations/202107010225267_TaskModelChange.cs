namespace Truck_Delivery_Tracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaskModelChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "isFinished", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "isFinished");
        }
    }
}
