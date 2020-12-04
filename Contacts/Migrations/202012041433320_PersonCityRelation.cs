namespace Contacts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonCityRelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "CityID", c => c.Int(nullable: false));
            CreateIndex("dbo.People", "CityID");
            AddForeignKey("dbo.People", "CityID", "dbo.Cities", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "CityID", "dbo.Cities");
            DropIndex("dbo.People", new[] { "CityID" });
            DropColumn("dbo.People", "CityID");
        }
    }
}
