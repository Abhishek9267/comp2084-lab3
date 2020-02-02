namespace PhoneApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Phones", "Founded", c => c.DateTime(nullable: false));
            DropColumn("dbo.Phones", "DateReleased");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Phones", "DateReleased", c => c.DateTime(nullable: false));
            DropColumn("dbo.Phones", "Founded");
        }
    }
}
