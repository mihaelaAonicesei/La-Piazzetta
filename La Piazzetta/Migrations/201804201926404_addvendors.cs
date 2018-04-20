namespace La_Piazzetta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addvendors : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ingredients", "Vendors_Id", "dbo.Vendors");
            DropIndex("dbo.Ingredients", new[] { "Vendors_Id" });
            RenameColumn(table: "dbo.Ingredients", name: "Vendors_Id", newName: "VendorId");
            AddColumn("dbo.Vendors", "PhoneNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Ingredients", "VendorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Ingredients", "VendorId");
            AddForeignKey("dbo.Ingredients", "VendorId", "dbo.Vendors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ingredients", "VendorId", "dbo.Vendors");
            DropIndex("dbo.Ingredients", new[] { "VendorId" });
            AlterColumn("dbo.Ingredients", "VendorId", c => c.Int());
            DropColumn("dbo.Vendors", "PhoneNumber");
            RenameColumn(table: "dbo.Ingredients", name: "VendorId", newName: "Vendors_Id");
            CreateIndex("dbo.Ingredients", "Vendors_Id");
            AddForeignKey("dbo.Ingredients", "Vendors_Id", "dbo.Vendors", "Id");
        }
    }
}
