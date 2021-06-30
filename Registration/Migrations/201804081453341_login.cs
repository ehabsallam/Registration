namespace Registration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class login : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_name = c.String(nullable: false),
                        user_password = c.String(nullable: false),
                        user_type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.users");
        }
    }
}
