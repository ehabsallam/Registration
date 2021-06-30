namespace Registration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.idea_professor", "accept_reject_idea", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.idea_professor", "accept_reject_idea", c => c.Boolean(nullable: true));
        }
    }
}
