namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GuestPasswordAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Guest", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Guest", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Guest", "Password", c => c.String());
            AlterColumn("dbo.Guest", "Username", c => c.String());
        }
    }
}
