namespace LayoutView.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrt1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Regno = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Course = c.String(),
                        GPA = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Regno);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
