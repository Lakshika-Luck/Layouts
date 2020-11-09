namespace LayoutView.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgrt2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "ProfilePic", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "ProfilePic");
        }
    }
}
