namespace Project2WooxTravel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class emaildeleted : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reservations", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "Email", c => c.String());
        }
    }
}
