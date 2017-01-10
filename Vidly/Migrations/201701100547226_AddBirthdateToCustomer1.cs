namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateToCustomer1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1944-10-06' AS DATETIME) WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
