namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationshipToDoctorTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctor", "Department_Id", c => c.Byte());
            AddColumn("dbo.Doctor", "UserType_Id", c => c.Byte());
            CreateIndex("dbo.Doctor", "Department_Id");
            CreateIndex("dbo.Doctor", "UserType_Id");
            AddForeignKey("dbo.Doctor", "Department_Id", "dbo.Departments", "Id");
            AddForeignKey("dbo.Doctor", "UserType_Id", "dbo.UserTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctor", "UserType_Id", "dbo.UserTypes");
            DropForeignKey("dbo.Doctor", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Doctor", new[] { "UserType_Id" });
            DropIndex("dbo.Doctor", new[] { "Department_Id" });
            DropColumn("dbo.Doctor", "UserType_Id");
            DropColumn("dbo.Doctor", "Department_Id");
        }
    }
}
