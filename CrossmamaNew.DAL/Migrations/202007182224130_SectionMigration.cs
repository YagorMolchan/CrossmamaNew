namespace CrossmamaNew.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SectionMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Categories", "SectionId", c => c.Int());
            CreateIndex("dbo.Categories", "SectionId");
            AddForeignKey("dbo.Categories", "SectionId", "dbo.Sections", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "SectionId", "dbo.Sections");
            DropIndex("dbo.Categories", new[] { "SectionId" });
            DropColumn("dbo.Categories", "SectionId");
            DropTable("dbo.Sections");
        }
    }
}
