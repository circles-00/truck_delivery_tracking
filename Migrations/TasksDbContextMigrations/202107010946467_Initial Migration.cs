namespace Truck_Delivery_Tracking.Migrations.TasksDbContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(nullable: false),
                        destination = c.String(nullable: false),
                        distance = c.Single(nullable: false),
                        dueDate = c.DateTime(nullable: false),
                        departure = c.DateTime(nullable: false),
                        cargo_content = c.String(),
                        cargo_type = c.String(nullable: false),
                        cargo_weight = c.Single(nullable: false),
                        isFinished = c.String(nullable: false),
                        driver = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tasks");
        }
    }
}
