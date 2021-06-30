namespace Registration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.professors", "DeptID", c => c.Int(nullable: false));
            AddColumn("dbo.professors", "Department_Id", c => c.Int());
            CreateIndex("dbo.professors", "Department_Id");
            AddForeignKey("dbo.professors", "Department_Id", "dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.professors", "Department_Id", "dbo.Departments");
            DropIndex("dbo.professors", new[] { "Department_Id" });
            DropColumn("dbo.professors", "Department_Id");
            DropColumn("dbo.professors", "DeptID");
            DropTable("dbo.Departments");
        }
    }
}
