namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTreatmentTableWithRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Treatments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Doctor_Id = c.Int(),
                        Patient_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctor", t => t.Doctor_Id)
                .ForeignKey("dbo.Patient", t => t.Patient_Id)
                .Index(t => t.Doctor_Id)
                .Index(t => t.Patient_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Treatments", "Patient_Id", "dbo.Patient");
            DropForeignKey("dbo.Treatments", "Doctor_Id", "dbo.Doctor");
            DropIndex("dbo.Treatments", new[] { "Patient_Id" });
            DropIndex("dbo.Treatments", new[] { "Doctor_Id" });
            DropTable("dbo.Treatments");
        }
    }
}
