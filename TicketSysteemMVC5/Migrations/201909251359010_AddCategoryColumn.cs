namespace TicketSysteemMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Categorie", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "Categorie");
        }
    }
}
