namespace StorageSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Single(nullable: false),
                        Production_Date = c.DateTime(nullable: false),
                        Expire_Date = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.category_Id)
                .Index(t => t.category_Id);
            
            CreateTable(
                "dbo.Customer_Invoice_Product",
                c => new
                    {
                        Customer_Invoice_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Customer_Invoice_Id, t.Product_Id })
                .ForeignKey("dbo.Customer_Invoice", t => t.Customer_Invoice_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Customer_Invoice_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Customer_Invoice",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        Customer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.Customer_ID)
                .Index(t => t.Customer_ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductStorages",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Storage_Id = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Storage_Id })
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.Storages", t => t.Storage_Id, cascadeDelete: true)
                .Index(t => t.Product_Id)
                .Index(t => t.Storage_Id);
            
            CreateTable(
                "dbo.Storages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Capacity = c.Int(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Supplier_Invoice_Product",
                c => new
                    {
                        Supplier_Invoice_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Supplier_Invoice_Id, t.Product_Id })
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.Supplier_Invoice", t => t.Supplier_Invoice_Id, cascadeDelete: true)
                .Index(t => t.Supplier_Invoice_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Supplier_Invoice",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Supplier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_Id)
                .Index(t => t.Supplier_Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Supplier_Invoice_Product", "Supplier_Invoice_Id", "dbo.Supplier_Invoice");
            DropForeignKey("dbo.Supplier_Invoice", "Supplier_Id", "dbo.Suppliers");
            DropForeignKey("dbo.Supplier_Invoice_Product", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductStorages", "Storage_Id", "dbo.Storages");
            DropForeignKey("dbo.ProductStorages", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Customer_Invoice_Product", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Customer_Invoice_Product", "Customer_Invoice_Id", "dbo.Customer_Invoice");
            DropForeignKey("dbo.Customer_Invoice", "Customer_ID", "dbo.Customers");
            DropForeignKey("dbo.Products", "category_Id", "dbo.Categories");
            DropIndex("dbo.Supplier_Invoice", new[] { "Supplier_Id" });
            DropIndex("dbo.Supplier_Invoice_Product", new[] { "Product_Id" });
            DropIndex("dbo.Supplier_Invoice_Product", new[] { "Supplier_Invoice_Id" });
            DropIndex("dbo.ProductStorages", new[] { "Storage_Id" });
            DropIndex("dbo.ProductStorages", new[] { "Product_Id" });
            DropIndex("dbo.Customer_Invoice", new[] { "Customer_ID" });
            DropIndex("dbo.Customer_Invoice_Product", new[] { "Product_Id" });
            DropIndex("dbo.Customer_Invoice_Product", new[] { "Customer_Invoice_Id" });
            DropIndex("dbo.Products", new[] { "category_Id" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Supplier_Invoice");
            DropTable("dbo.Supplier_Invoice_Product");
            DropTable("dbo.Storages");
            DropTable("dbo.ProductStorages");
            DropTable("dbo.Customers");
            DropTable("dbo.Customer_Invoice");
            DropTable("dbo.Customer_Invoice_Product");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
