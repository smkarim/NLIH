namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTechnicalTableWithRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TechnicalEmployee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserType_Id = c.Byte(),
                        Name = c.String(),
                        Address = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        Designation = c.String(),
                        LastExperiance = c.String(),
                        JoinedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserTypes", t => t.UserType_Id)
                .Index(t => t.UserType_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TechnicalEmployee", "UserType_Id", "dbo.UserTypes");
            DropIndex("dbo.TechnicalEmployee", new[] { "UserType_Id" });
            DropTable("dbo.TechnicalEmployee");
        }
    }
}
