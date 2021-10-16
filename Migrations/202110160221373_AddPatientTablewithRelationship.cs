namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPatientTablewithRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Patient",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        UserType_Id = c.Byte(),
                        Name = c.String(),
                        Address = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        AdmissionDate = c.DateTime(nullable: false),
                        ReleaseDate = c.DateTime(),
                        RoomNo = c.Byte(nullable: false),
                        Issues = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserTypes", t => t.UserType_Id)
                .Index(t => t.UserType_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patient", "UserType_Id", "dbo.UserTypes");
            DropIndex("dbo.Patient", new[] { "UserType_Id" });
            DropTable("dbo.Patient");
        }
    }
}
