namespace Registration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fornkey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.students", "leader_fr_id", c => c.Int());
            CreateIndex("dbo.students", "leader_fr_id");
            AddForeignKey("dbo.students", "leader_fr_id", "dbo.teamLeaders", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.students", "leader_fr_id", "dbo.teamLeaders");
            DropIndex("dbo.students", new[] { "leader_fr_id" });
            DropColumn("dbo.students", "leader_fr_id");
        }
    }
}
