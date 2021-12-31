namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewAddition : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Guest", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Guest", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Doctor", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Doctor", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Patient", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Patient", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Accounts", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Accounts", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Admin", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Admin", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Finance", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Finance", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Nurse", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Nurse", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Staff", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Staff", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.TechnicalEmployee", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.TechnicalEmployee", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TechnicalEmployee", "Address", c => c.String());
            AlterColumn("dbo.TechnicalEmployee", "Name", c => c.String());
            AlterColumn("dbo.Staff", "Address", c => c.String());
            AlterColumn("dbo.Staff", "Name", c => c.String());
            AlterColumn("dbo.Nurse", "Address", c => c.String());
            AlterColumn("dbo.Nurse", "Name", c => c.String());
            AlterColumn("dbo.Finance", "Address", c => c.String());
            AlterColumn("dbo.Finance", "Name", c => c.String());
            AlterColumn("dbo.Admin", "Address", c => c.String());
            AlterColumn("dbo.Admin", "Name", c => c.String());
            AlterColumn("dbo.Accounts", "Address", c => c.String());
            AlterColumn("dbo.Accounts", "Name", c => c.String());
            AlterColumn("dbo.Patient", "Address", c => c.String());
            AlterColumn("dbo.Patient", "Name", c => c.String());
            AlterColumn("dbo.Doctor", "Address", c => c.String());
            AlterColumn("dbo.Doctor", "Name", c => c.String());
            AlterColumn("dbo.Guest", "Address", c => c.String());
            AlterColumn("dbo.Guest", "Name", c => c.String());
        }
    }
}
