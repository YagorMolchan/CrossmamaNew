namespace CrossmamaNew.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
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
                "dbo.CategoryNounGenders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(),
                        NounId = c.Int(),
                        GenderId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.Genders", t => t.GenderId)
                .ForeignKey("dbo.Nouns", t => t.NounId)
                .Index(t => t.CategoryId)
                .Index(t => t.NounId)
                .Index(t => t.GenderId);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Lots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenderId = c.Int(),
                        CategoryId = c.Int(),
                        NounId = c.Int(),
                        SizeId = c.Int(),
                        StateId = c.Int(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.Genders", t => t.GenderId)
                .ForeignKey("dbo.Nouns", t => t.NounId)
                .ForeignKey("dbo.Sizes", t => t.SizeId)
                .ForeignKey("dbo.States", t => t.StateId)
                .Index(t => t.GenderId)
                .Index(t => t.CategoryId)
                .Index(t => t.NounId)
                .Index(t => t.SizeId)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.LotColors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LotId = c.Int(),
                        ColorId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colors", t => t.ColorId)
                .ForeignKey("dbo.Lots", t => t.LotId)
                .Index(t => t.LotId)
                .Index(t => t.ColorId);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LotStructures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LotId = c.Int(),
                        StructureId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lots", t => t.LotId)
                .ForeignKey("dbo.Structures", t => t.StructureId)
                .Index(t => t.LotId)
                .Index(t => t.StructureId);
            
            CreateTable(
                "dbo.Structures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Nouns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                        MValue = c.String(),
                        FValue = c.String(),
                        Age = c.String(),
                        Height = c.String(),
                        EUValue = c.String(),
                        UKValue = c.String(),
                        USAValue = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Parents",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Parents", "Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Lots", "StateId", "dbo.States");
            DropForeignKey("dbo.Lots", "SizeId", "dbo.Sizes");
            DropForeignKey("dbo.Lots", "NounId", "dbo.Nouns");
            DropForeignKey("dbo.CategoryNounGenders", "NounId", "dbo.Nouns");
            DropForeignKey("dbo.LotStructures", "StructureId", "dbo.Structures");
            DropForeignKey("dbo.LotStructures", "LotId", "dbo.Lots");
            DropForeignKey("dbo.LotColors", "LotId", "dbo.Lots");
            DropForeignKey("dbo.LotColors", "ColorId", "dbo.Colors");
            DropForeignKey("dbo.Lots", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.Lots", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.CategoryNounGenders", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.CategoryNounGenders", "CategoryId", "dbo.Categories");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Parents", new[] { "Id" });
            DropIndex("dbo.LotStructures", new[] { "StructureId" });
            DropIndex("dbo.LotStructures", new[] { "LotId" });
            DropIndex("dbo.LotColors", new[] { "ColorId" });
            DropIndex("dbo.LotColors", new[] { "LotId" });
            DropIndex("dbo.Lots", new[] { "StateId" });
            DropIndex("dbo.Lots", new[] { "SizeId" });
            DropIndex("dbo.Lots", new[] { "NounId" });
            DropIndex("dbo.Lots", new[] { "CategoryId" });
            DropIndex("dbo.Lots", new[] { "GenderId" });
            DropIndex("dbo.CategoryNounGenders", new[] { "GenderId" });
            DropIndex("dbo.CategoryNounGenders", new[] { "NounId" });
            DropIndex("dbo.CategoryNounGenders", new[] { "CategoryId" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Parents");
            DropTable("dbo.States");
            DropTable("dbo.Sizes");
            DropTable("dbo.Nouns");
            DropTable("dbo.Structures");
            DropTable("dbo.LotStructures");
            DropTable("dbo.Colors");
            DropTable("dbo.LotColors");
            DropTable("dbo.Lots");
            DropTable("dbo.Genders");
            DropTable("dbo.CategoryNounGenders");
            DropTable("dbo.Categories");
        }
    }
}
