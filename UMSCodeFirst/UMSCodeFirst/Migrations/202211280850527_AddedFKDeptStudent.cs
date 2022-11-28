namespace UMSCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFKDeptStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "DId", c => c.Int());
            CreateIndex("dbo.Students", "DId");
            AddForeignKey("dbo.Students", "DId", "dbo.Departments", "DeptId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "DId", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "DId" });
            DropColumn("dbo.Students", "DId");
        }
    }
}
