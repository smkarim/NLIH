namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserTypeIdtoPatient : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Patient", "UserType_Id", "dbo.UserTypes");
            DropIndex("dbo.Patient", new[] { "UserType_Id" });
            RenameColumn(table: "dbo.Patient", name: "UserType_Id", newName: "UserTypeId");
            AlterColumn("dbo.Patient", "UserTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Patient", "UserTypeId");
            AddForeignKey("dbo.Patient", "UserTypeId", "dbo.UserTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patient", "UserTypeId", "dbo.UserTypes");
            DropIndex("dbo.Patient", new[] { "UserTypeId" });
            AlterColumn("dbo.Patient", "UserTypeId", c => c.Byte());
            RenameColumn(table: "dbo.Patient", name: "UserTypeId", newName: "UserType_Id");
            CreateIndex("dbo.Patient", "UserType_Id");
            AddForeignKey("dbo.Patient", "UserType_Id", "dbo.UserTypes", "Id");
        }
    }
}
