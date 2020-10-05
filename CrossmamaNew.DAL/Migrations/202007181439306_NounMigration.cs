namespace CrossmamaNew.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NounMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CategoryNounGenders", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.CategoryNounGenders", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.CategoryNounGenders", "NounId", "dbo.Nouns");
            DropIndex("dbo.CategoryNounGenders", new[] { "CategoryId" });
            DropIndex("dbo.CategoryNounGenders", new[] { "NounId" });
            DropIndex("dbo.CategoryNounGenders", new[] { "GenderId" });
            AddColumn("dbo.Nouns", "CategoryId", c => c.Int());
            CreateIndex("dbo.Nouns", "CategoryId");
            AddForeignKey("dbo.Nouns", "CategoryId", "dbo.Categories", "Id");
            DropTable("dbo.CategoryNounGenders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CategoryNounGenders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(),
                        NounId = c.Int(),
                        GenderId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Nouns", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Nouns", new[] { "CategoryId" });
            DropColumn("dbo.Nouns", "CategoryId");
            CreateIndex("dbo.CategoryNounGenders", "GenderId");
            CreateIndex("dbo.CategoryNounGenders", "NounId");
            CreateIndex("dbo.CategoryNounGenders", "CategoryId");
            AddForeignKey("dbo.CategoryNounGenders", "NounId", "dbo.Nouns", "Id");
            AddForeignKey("dbo.CategoryNounGenders", "GenderId", "dbo.Genders", "Id");
            AddForeignKey("dbo.CategoryNounGenders", "CategoryId", "dbo.Categories", "Id");
        }
    }
}
