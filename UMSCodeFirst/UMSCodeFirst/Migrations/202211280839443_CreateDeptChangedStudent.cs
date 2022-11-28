namespace UMSCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDeptChangedStudent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DeptId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.DeptId);
            
            AddColumn("dbo.Students", "Cgpa", c => c.Double());
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Name", c => c.String());
            DropColumn("dbo.Students", "Cgpa");
            DropTable("dbo.Departments");
        }
    }
}
