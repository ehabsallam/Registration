namespace Registration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class class1force : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Class1",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Class1");
        }
    }
}
