namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFinanceTableWithRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Finance",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        UserType_Id = c.Byte(),
                        Name = c.String(),
                        Address = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        JoinedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserTypes", t => t.UserType_Id)
                .Index(t => t.UserType_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Finance", "UserType_Id", "dbo.UserTypes");
            DropIndex("dbo.Finance", new[] { "UserType_Id" });
            DropTable("dbo.Finance");
        }
    }
}
