namespace TicketSysteemMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Ticket_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Ticket_Id");
            AddForeignKey("dbo.AspNetUsers", "Ticket_Id", "dbo.Tickets", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "Ticket_Id", "dbo.Tickets");
            DropIndex("dbo.AspNetUsers", new[] { "Ticket_Id" });
            DropColumn("dbo.AspNetUsers", "Ticket_Id");
        }
    }
}
