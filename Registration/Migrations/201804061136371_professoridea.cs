namespace Registration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class professoridea : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.idea_professor",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        idea_id_fk = c.Int(nullable: false),
                        professor_id_fk = c.Int(nullable: false),
                        accept_reject_idea = c.Boolean(nullable: true),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.professors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        professor_name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.professors");
            DropTable("dbo.idea_professor");
        }
    }
}
