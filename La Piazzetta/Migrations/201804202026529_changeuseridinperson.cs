namespace La_Piazzetta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeuseridinperson : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.People", new[] { "User_Id" });
            DropColumn("dbo.People", "UserId");
            RenameColumn(table: "dbo.People", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.People", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.People", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.People", new[] { "UserId" });
            AlterColumn("dbo.People", "UserId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.People", name: "UserId", newName: "User_Id");
            AddColumn("dbo.People", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.People", "User_Id");
        }
    }
}
