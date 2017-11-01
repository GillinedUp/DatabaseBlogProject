namespace DatabaseBlogProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBlog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "User_UserName", c => c.String(maxLength: 128));
            CreateIndex("dbo.Blogs", "User_UserName");
            AddForeignKey("dbo.Blogs", "User_UserName", "dbo.Users", "UserName");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blogs", "User_UserName", "dbo.Users");
            DropIndex("dbo.Blogs", new[] { "User_UserName" });
            DropColumn("dbo.Blogs", "User_UserName");
        }
    }
}
