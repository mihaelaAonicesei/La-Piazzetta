namespace La_Piazzetta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addemployees : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        EmploymentStartDate = c.DateTime(nullable: false),
                        EmploymentEndDate = c.DateTime(nullable: false),
                        Position = c.String(),
                        Salary = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
