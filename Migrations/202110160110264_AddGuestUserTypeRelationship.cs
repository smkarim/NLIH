namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGuestUserTypeRelationship : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guest", "UserType_Id", c => c.Byte());
            CreateIndex("dbo.Guest", "UserType_Id");
            AddForeignKey("dbo.Guest", "UserType_Id", "dbo.UserTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Guest", "UserType_Id", "dbo.UserTypes");
            DropIndex("dbo.Guest", new[] { "UserType_Id" });
            DropColumn("dbo.Guest", "UserType_Id");
        }
    }
}
