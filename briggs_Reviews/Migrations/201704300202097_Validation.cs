namespace briggs_Reviews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "Content", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "FaveMovie", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "FaveMovie", c => c.String());
            AlterColumn("dbo.Reviews", "Content", c => c.String());
        }
    }
}
