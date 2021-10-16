namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDoctorTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctor",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Address = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        Specialization = c.String(),
                        ContactNo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Doctor");
        }
    }
}
