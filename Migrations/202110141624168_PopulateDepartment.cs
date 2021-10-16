namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDepartment : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Departments (Id, Name, IsActive) values (1,'Cardiac/Heart Department',1)");
            Sql("Insert into Departments (Id, Name, IsActive) values (2,'Nephrology/Kidney Department',1)");
            Sql("Insert into Departments (Id, Name, IsActive) values (3,'ENT or Ear/Nose/Throat Department',1)");
            Sql("Insert into Departments (Id, Name, IsActive) values (4,'Maternity/Mother & Baby Department',1)");
            Sql("Insert into Departments (Id, Name, IsActive) values (5,'General Department',1)");
            Sql("Insert into Departments (Id, Name, IsActive) values (6,'Emergency',1)");
        }

        public override void Down()
        {
        }
    }
}
