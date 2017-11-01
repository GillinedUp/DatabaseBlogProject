namespace DatabaseBlogProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUserId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Blogs", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blogs", "UserId", c => c.String());
        }
    }
}
