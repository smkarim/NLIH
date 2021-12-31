namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTypeIdtoGuest : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Guest", "UserType_Id", "dbo.UserTypes");
            DropIndex("dbo.Guest", new[] { "UserType_Id" });
            RenameColumn(table: "dbo.Guest", name: "UserType_Id", newName: "UserTypeId");
            AlterColumn("dbo.Guest", "UserTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Guest", "UserTypeId");
            AddForeignKey("dbo.Guest", "UserTypeId", "dbo.UserTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Guest", "UserTypeId", "dbo.UserTypes");
            DropIndex("dbo.Guest", new[] { "UserTypeId" });
            AlterColumn("dbo.Guest", "UserTypeId", c => c.Byte());
            RenameColumn(table: "dbo.Guest", name: "UserTypeId", newName: "UserType_Id");
            CreateIndex("dbo.Guest", "UserType_Id");
            AddForeignKey("dbo.Guest", "UserType_Id", "dbo.UserTypes", "Id");
        }
    }
}
