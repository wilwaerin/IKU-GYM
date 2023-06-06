namespace webproje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration38 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Purchases", "NameSurname", c => c.String(nullable: false));
            AlterColumn("dbo.Purchases", "Mail", c => c.String(nullable: false));
            AlterColumn("dbo.Purchases", "Gender", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Purchases", "Gender", c => c.String());
            AlterColumn("dbo.Purchases", "Mail", c => c.String());
            AlterColumn("dbo.Purchases", "NameSurname", c => c.String());
        }
    }
}
