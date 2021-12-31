namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNurseTableWithRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nurse",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserType_Id = c.Byte(),
                        Name = c.String(),
                        Address = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        JoinedDate = c.DateTime(nullable: false),
                        SupervisorName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserTypes", t => t.UserType_Id)
                .Index(t => t.UserType_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Nurse", "UserType_Id", "dbo.UserTypes");
            DropIndex("dbo.Nurse", new[] { "UserType_Id" });
            DropTable("dbo.Nurse");
        }
    }
}
