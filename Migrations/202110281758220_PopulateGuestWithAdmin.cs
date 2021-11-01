namespace NLIH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGuestWithAdmin : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Guest (Id, Name, Address,DateOfBirth,Email,Username,Password,UserType_Id) values (1,'Admin User','NLIH','1-Jan-1990','admin@nlih.org','Admin1','nlih123',1)");
        }
        
        public override void Down()
        {
        }
    }
}
