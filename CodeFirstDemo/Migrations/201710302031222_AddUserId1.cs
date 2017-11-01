namespace DatabaseBlogProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserId1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "UserId");
        }
    }
}
