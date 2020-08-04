namespace Acme.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Surname = c.String(),
                        WorkEmail = c.String(),
                        PersonalEmail = c.String(),
                        StartDate = c.DateTime(),
                        EnteredByUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUsers", t => t.EnteredByUserId, cascadeDelete: true)
                .Index(t => t.EnteredByUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "EnteredByUserId", "dbo.ApplicationUsers");
            DropIndex("dbo.Employees", new[] { "EnteredByUserId" });
            DropTable("dbo.Employees");
            DropTable("dbo.ApplicationUsers");
        }
    }
}
