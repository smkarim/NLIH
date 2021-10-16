namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTimeTableWithRelationships : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TimeTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CheckingSchedule = c.DateTime(nullable: false),
                        ReasonsForChecking = c.String(),
                        Doctor_Id = c.Int(),
                        Guest_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctor", t => t.Doctor_Id)
                .ForeignKey("dbo.Guest", t => t.Guest_Id)
                .Index(t => t.Doctor_Id)
                .Index(t => t.Guest_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TimeTables", "Guest_Id", "dbo.Guest");
            DropForeignKey("dbo.TimeTables", "Doctor_Id", "dbo.Doctor");
            DropIndex("dbo.TimeTables", new[] { "Guest_Id" });
            DropIndex("dbo.TimeTables", new[] { "Doctor_Id" });
            DropTable("dbo.TimeTables");
        }
    }
}
