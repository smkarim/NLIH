namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdminTableWithRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserType_Id = c.Byte(),
                        Name = c.String(),
                        Address = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        JoinedDate = c.DateTime(nullable: false),
                        LastExperiance = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserTypes", t => t.UserType_Id)
                .Index(t => t.UserType_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Admin", "UserType_Id", "dbo.UserTypes");
            DropIndex("dbo.Admin", new[] { "UserType_Id" });
            DropTable("dbo.Admin");
        }
    }
}
