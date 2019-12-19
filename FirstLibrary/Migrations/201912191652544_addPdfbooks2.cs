namespace FirstLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPdfbooks2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "EBook", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "EBook");
        }
    }
}
