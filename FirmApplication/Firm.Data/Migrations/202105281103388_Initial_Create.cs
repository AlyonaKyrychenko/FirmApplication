namespace Firm.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Foremen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        MonthsOfExperience = c.Int(nullable: false),
                        Postition = c.String(),
                        CompanyName = c.String(),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        MonthsOfExperience = c.Int(nullable: false),
                        Postition = c.String(),
                        CompanyName = c.String(),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        MonthsOfExperience = c.Int(nullable: false),
                        Postition = c.String(),
                        CompanyName = c.String(),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .Index(t => t.Company_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Workers", "Company_Id", "dbo.Companies");
            DropForeignKey("dbo.Managers", "Company_Id", "dbo.Companies");
            DropForeignKey("dbo.Foremen", "Company_Id", "dbo.Companies");
            DropIndex("dbo.Workers", new[] { "Company_Id" });
            DropIndex("dbo.Managers", new[] { "Company_Id" });
            DropIndex("dbo.Foremen", new[] { "Company_Id" });
            DropTable("dbo.Workers");
            DropTable("dbo.Managers");
            DropTable("dbo.Foremen");
            DropTable("dbo.Companies");
        }
    }
}
