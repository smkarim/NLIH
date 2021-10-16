namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAccountsTableWithRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
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
            DropForeignKey("dbo.Accounts", "UserType_Id", "dbo.UserTypes");
            DropIndex("dbo.Accounts", new[] { "UserType_Id" });
            DropTable("dbo.Accounts");
        }
    }
}
