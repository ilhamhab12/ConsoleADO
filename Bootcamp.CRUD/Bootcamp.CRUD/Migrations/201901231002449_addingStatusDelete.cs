namespace Bootcamp.CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingStatusDelete : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Suppliers", "IsDelete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Suppliers", "IsDelete");
        }
    }
}
