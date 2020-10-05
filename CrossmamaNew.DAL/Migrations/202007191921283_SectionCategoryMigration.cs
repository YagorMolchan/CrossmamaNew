namespace CrossmamaNew.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SectionCategoryMigration : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Lots", name: "CategoryId", newName: "Category_Id");
            RenameIndex(table: "dbo.Lots", name: "IX_CategoryId", newName: "IX_Category_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Lots", name: "IX_Category_Id", newName: "IX_CategoryId");
            RenameColumn(table: "dbo.Lots", name: "Category_Id", newName: "CategoryId");
        }
    }
}
