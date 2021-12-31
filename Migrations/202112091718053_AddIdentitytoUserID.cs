namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIdentitytoUserID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TimeTables", "Guest_Id", "dbo.Guest");
            DropForeignKey("dbo.TimeTables", "Doctor_Id", "dbo.Doctor");
            DropForeignKey("dbo.Treatments", "Doctor_Id", "dbo.Doctor");
            DropForeignKey("dbo.Treatments", "Patient_Id", "dbo.Patient");
            DropPrimaryKey("dbo.Guest");
            DropPrimaryKey("dbo.Doctor");
            DropPrimaryKey("dbo.Patient");
            DropPrimaryKey("dbo.Accounts");
            DropPrimaryKey("dbo.Admin");
            DropPrimaryKey("dbo.Finance");
            DropPrimaryKey("dbo.Nurse");
            DropPrimaryKey("dbo.Staff");
            DropPrimaryKey("dbo.TechnicalEmployee");
            AlterColumn("dbo.Guest", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Doctor", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Patient", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Accounts", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Admin", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Finance", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Nurse", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Staff", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.TechnicalEmployee", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Guest", "Id");
            AddPrimaryKey("dbo.Doctor", "Id");
            AddPrimaryKey("dbo.Patient", "Id");
            AddPrimaryKey("dbo.Accounts", "Id");
            AddPrimaryKey("dbo.Admin", "Id");
            AddPrimaryKey("dbo.Finance", "Id");
            AddPrimaryKey("dbo.Nurse", "Id");
            AddPrimaryKey("dbo.Staff", "Id");
            AddPrimaryKey("dbo.TechnicalEmployee", "Id");
            AddForeignKey("dbo.TimeTables", "Guest_Id", "dbo.Guest", "Id");
            AddForeignKey("dbo.TimeTables", "Doctor_Id", "dbo.Doctor", "Id");
            AddForeignKey("dbo.Treatments", "Doctor_Id", "dbo.Doctor", "Id");
            AddForeignKey("dbo.Treatments", "Patient_Id", "dbo.Patient", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Treatments", "Patient_Id", "dbo.Patient");
            DropForeignKey("dbo.Treatments", "Doctor_Id", "dbo.Doctor");
            DropForeignKey("dbo.TimeTables", "Doctor_Id", "dbo.Doctor");
            DropForeignKey("dbo.TimeTables", "Guest_Id", "dbo.Guest");
            DropPrimaryKey("dbo.TechnicalEmployee");
            DropPrimaryKey("dbo.Staff");
            DropPrimaryKey("dbo.Nurse");
            DropPrimaryKey("dbo.Finance");
            DropPrimaryKey("dbo.Admin");
            DropPrimaryKey("dbo.Accounts");
            DropPrimaryKey("dbo.Patient");
            DropPrimaryKey("dbo.Doctor");
            DropPrimaryKey("dbo.Guest");
            AlterColumn("dbo.TechnicalEmployee", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Staff", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Nurse", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Finance", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Admin", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Accounts", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Patient", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Doctor", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Guest", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.TechnicalEmployee", "Id");
            AddPrimaryKey("dbo.Staff", "Id");
            AddPrimaryKey("dbo.Nurse", "Id");
            AddPrimaryKey("dbo.Finance", "Id");
            AddPrimaryKey("dbo.Admin", "Id");
            AddPrimaryKey("dbo.Accounts", "Id");
            AddPrimaryKey("dbo.Patient", "Id");
            AddPrimaryKey("dbo.Doctor", "Id");
            AddPrimaryKey("dbo.Guest", "Id");
            AddForeignKey("dbo.Treatments", "Patient_Id", "dbo.Patient", "Id");
            AddForeignKey("dbo.Treatments", "Doctor_Id", "dbo.Doctor", "Id");
            AddForeignKey("dbo.TimeTables", "Doctor_Id", "dbo.Doctor", "Id");
            AddForeignKey("dbo.TimeTables", "Guest_Id", "dbo.Guest", "Id");
        }
    }
}
