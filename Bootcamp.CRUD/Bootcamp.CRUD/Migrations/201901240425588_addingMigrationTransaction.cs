namespace Bootcamp.CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingMigrationTransaction : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TransactionItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        Items_Id = c.Int(),
                        Transactions_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.Items_Id)
                .ForeignKey("dbo.Transactions", t => t.Transactions_Id)
                .Index(t => t.Items_Id)
                .Index(t => t.Transactions_Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransactionDate = c.DateTimeOffset(nullable: false, precision: 7),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionItems", "Transactions_Id", "dbo.Transactions");
            DropForeignKey("dbo.TransactionItems", "Items_Id", "dbo.Items");
            DropIndex("dbo.TransactionItems", new[] { "Transactions_Id" });
            DropIndex("dbo.TransactionItems", new[] { "Items_Id" });
            DropTable("dbo.Transactions");
            DropTable("dbo.TransactionItems");
        }
    }
}
