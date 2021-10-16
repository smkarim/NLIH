namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateUserType : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into UserTypes (Id, Name) values (1,'Guest')");
            Sql("Insert into UserTypes (Id, Name) values (2,'Doctor/Consultant')");
            Sql("Insert into UserTypes (Id, Name) values (3,'Patient')");
            Sql("Insert into UserTypes (Id, Name) values (4,'Nurse')");
            Sql("Insert into UserTypes (Id, Name) values (5,'Admin')");
            Sql("Insert into UserTypes (Id, Name) values (6,'Technical')");
            Sql("Insert into UserTypes (Id, Name) values (7,'Accounts')");
            Sql("Insert into UserTypes (Id, Name) values (8,'Finance')");
            Sql("Insert into UserTypes (Id, Name) values (9,'Administration')");
            Sql("Insert into UserTypes (Id, Name) values (10,'Staff')");
        }
        
        public override void Down()
        {
        }
    }
}
