namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStaffTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Staff",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Address = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        JoinedDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Staff");
        }
    }
}
