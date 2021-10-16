namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStaffUsertypeRelationship : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Staff", "UserType_Id", c => c.Byte());
            CreateIndex("dbo.Staff", "UserType_Id");
            AddForeignKey("dbo.Staff", "UserType_Id", "dbo.UserTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staff", "UserType_Id", "dbo.UserTypes");
            DropIndex("dbo.Staff", new[] { "UserType_Id" });
            DropColumn("dbo.Staff", "UserType_Id");
        }
    }
}
