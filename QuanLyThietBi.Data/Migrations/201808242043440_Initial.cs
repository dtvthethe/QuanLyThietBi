namespace QuanLyThietBi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Devices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Quantity = c.Int(nullable: false),
                        IDCategory = c.Int(nullable: false),
                        IDUnit = c.Int(nullable: false),
                        IDStatus = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Info = c.String(storeType: "ntext"),
                        CreatedBy = c.String(maxLength: 128),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        Note = c.String(storeType: "ntext"),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.IDCategory, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.CreatedBy)
                .ForeignKey("dbo.Statuses", t => t.IDStatus, cascadeDelete: true)
                .ForeignKey("dbo.Units", t => t.IDUnit, cascadeDelete: true)
                .Index(t => t.IDCategory)
                .Index(t => t.IDUnit)
                .Index(t => t.IDStatus)
                .Index(t => t.CreatedBy);
            
            CreateTable(
                "dbo.DeliveryDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDDevice = c.Int(nullable: false),
                        IDDelivery = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        DateExpires = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 128),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        Note = c.String(storeType: "ntext"),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Deliveries", t => t.IDDelivery, cascadeDelete: true)
                .ForeignKey("dbo.Devices", t => t.IDDevice, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.CreatedBy)
                .Index(t => t.IDDevice)
                .Index(t => t.IDDelivery)
                .Index(t => t.CreatedBy);
            
            CreateTable(
                "dbo.Deliveries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDUserDelivery = c.String(maxLength: 128),
                        CreatedBy = c.String(maxLength: 128),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        Note = c.String(storeType: "ntext"),
                        UpdatedBy = c.String(maxLength: 256),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Users", t => t.CreatedBy)
                .ForeignKey("dbo.Users", t => t.IDUserDelivery)
                .Index(t => t.IDUserDelivery)
                .Index(t => t.CreatedBy)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(nullable: false, maxLength: 256),
                        Address = c.String(nullable: false, maxLength: 256),
                        BirthDay = c.DateTime(nullable: false),
                        IDDepartment = c.Int(nullable: false),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.IDDepartment, cascadeDelete: true)
                .Index(t => t.IDDepartment);
            
            CreateTable(
                "dbo.ApplicationUserClaims",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        Id = c.Int(nullable: false),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ApplicationUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Receipts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDProvider = c.Int(nullable: false),
                        CreatedBy = c.String(maxLength: 128),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        Note = c.String(storeType: "ntext"),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Providers", t => t.IDProvider, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.CreatedBy)
                .Index(t => t.IDProvider)
                .Index(t => t.CreatedBy);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ReceiptDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDReceipt = c.Int(nullable: false),
                        IDDevice = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CreatedBy = c.String(maxLength: 128),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        Note = c.String(storeType: "ntext"),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Devices", t => t.IDDevice, cascadeDelete: true)
                .ForeignKey("dbo.Receipts", t => t.IDReceipt, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.CreatedBy)
                .Index(t => t.IDReceipt)
                .Index(t => t.IDDevice)
                .Index(t => t.CreatedBy);
            
            CreateTable(
                "dbo.ApplicationUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Statuses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ApplicationUserRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Devices", "IDUnit", "dbo.Units");
            DropForeignKey("dbo.Devices", "IDStatus", "dbo.Statuses");
            DropForeignKey("dbo.DeliveryDetails", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.DeliveryDetails", "IDDevice", "dbo.Devices");
            DropForeignKey("dbo.Deliveries", "IDUserDelivery", "dbo.Users");
            DropForeignKey("dbo.Deliveries", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.ApplicationUserRoles", "UserId", "dbo.Users");
            DropForeignKey("dbo.Receipts", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.ReceiptDetails", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.ReceiptDetails", "IDReceipt", "dbo.Receipts");
            DropForeignKey("dbo.ReceiptDetails", "IDDevice", "dbo.Devices");
            DropForeignKey("dbo.Receipts", "IDProvider", "dbo.Providers");
            DropForeignKey("dbo.ApplicationUserLogins", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Devices", "CreatedBy", "dbo.Users");
            DropForeignKey("dbo.Users", "IDDepartment", "dbo.Departments");
            DropForeignKey("dbo.Deliveries", "User_Id", "dbo.Users");
            DropForeignKey("dbo.ApplicationUserClaims", "User_Id", "dbo.Users");
            DropForeignKey("dbo.DeliveryDetails", "IDDelivery", "dbo.Deliveries");
            DropForeignKey("dbo.Devices", "IDCategory", "dbo.Categories");
            DropIndex("dbo.ApplicationUserRoles", new[] { "RoleId" });
            DropIndex("dbo.ApplicationUserRoles", new[] { "UserId" });
            DropIndex("dbo.ReceiptDetails", new[] { "CreatedBy" });
            DropIndex("dbo.ReceiptDetails", new[] { "IDDevice" });
            DropIndex("dbo.ReceiptDetails", new[] { "IDReceipt" });
            DropIndex("dbo.Receipts", new[] { "CreatedBy" });
            DropIndex("dbo.Receipts", new[] { "IDProvider" });
            DropIndex("dbo.ApplicationUserLogins", new[] { "User_Id" });
            DropIndex("dbo.ApplicationUserClaims", new[] { "User_Id" });
            DropIndex("dbo.Users", new[] { "IDDepartment" });
            DropIndex("dbo.Deliveries", new[] { "User_Id" });
            DropIndex("dbo.Deliveries", new[] { "CreatedBy" });
            DropIndex("dbo.Deliveries", new[] { "IDUserDelivery" });
            DropIndex("dbo.DeliveryDetails", new[] { "CreatedBy" });
            DropIndex("dbo.DeliveryDetails", new[] { "IDDelivery" });
            DropIndex("dbo.DeliveryDetails", new[] { "IDDevice" });
            DropIndex("dbo.Devices", new[] { "CreatedBy" });
            DropIndex("dbo.Devices", new[] { "IDStatus" });
            DropIndex("dbo.Devices", new[] { "IDUnit" });
            DropIndex("dbo.Devices", new[] { "IDCategory" });
            DropTable("dbo.Roles");
            DropTable("dbo.Units");
            DropTable("dbo.Statuses");
            DropTable("dbo.ApplicationUserRoles");
            DropTable("dbo.ReceiptDetails");
            DropTable("dbo.Providers");
            DropTable("dbo.Receipts");
            DropTable("dbo.ApplicationUserLogins");
            DropTable("dbo.Departments");
            DropTable("dbo.ApplicationUserClaims");
            DropTable("dbo.Users");
            DropTable("dbo.Deliveries");
            DropTable("dbo.DeliveryDetails");
            DropTable("dbo.Devices");
            DropTable("dbo.Categories");
        }
    }
}
