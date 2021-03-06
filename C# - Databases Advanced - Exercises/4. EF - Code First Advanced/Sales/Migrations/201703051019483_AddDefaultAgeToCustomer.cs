using System.Data.Entity.Migrations;

namespace Sales.Migrations
{
    public partial class AddDefaultAgeToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Age", c => c.Int(nullable: false, defaultValue: 20));
        }

        public override void Down()
        {
            DropColumn("dbo.Customers", "Age");
        }
    }
}