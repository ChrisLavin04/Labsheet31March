namespace Labsheet31March.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRestaurantData : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bookings", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.Bookings", new[] { "Customer_CustomerId" });
            RenameColumn(table: "dbo.Bookings", name: "Customer_CustomerId", newName: "CustomerId");
            AddColumn("dbo.Bookings", "BookingDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Bookings", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Bookings", "CustomerId");
            AddForeignKey("dbo.Bookings", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            DropColumn("dbo.Bookings", "BookingsDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bookings", "BookingsDate", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.Bookings", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Bookings", new[] { "CustomerId" });
            AlterColumn("dbo.Bookings", "CustomerId", c => c.Int());
            DropColumn("dbo.Bookings", "BookingDate");
            RenameColumn(table: "dbo.Bookings", name: "CustomerId", newName: "Customer_CustomerId");
            CreateIndex("dbo.Bookings", "Customer_CustomerId");
            AddForeignKey("dbo.Bookings", "Customer_CustomerId", "dbo.Customers", "CustomerId");
        }
    }
}
