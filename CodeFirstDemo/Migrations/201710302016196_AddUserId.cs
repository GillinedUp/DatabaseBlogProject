namespace DatabaseBlogProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Blogs", "User_UserName", "dbo.Users");
            DropIndex("dbo.Blogs", new[] { "User_UserName" });
            RenameColumn(table: "dbo.Blogs", name: "User_UserName", newName: "User_UserId");
            DropPrimaryKey("dbo.Users");
            AddColumn("dbo.Users", "UserId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Blogs", "User_UserId", c => c.Int());
            AlterColumn("dbo.Users", "UserName", c => c.String());
            AddPrimaryKey("dbo.Users", "UserId");
            CreateIndex("dbo.Blogs", "User_UserId");
            AddForeignKey("dbo.Blogs", "User_UserId", "dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blogs", "User_UserId", "dbo.Users");
            DropIndex("dbo.Blogs", new[] { "User_UserId" });
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Blogs", "User_UserId", c => c.String(maxLength: 128));
            DropColumn("dbo.Users", "UserId");
            AddPrimaryKey("dbo.Users", "UserName");
            RenameColumn(table: "dbo.Blogs", name: "User_UserId", newName: "User_UserName");
            CreateIndex("dbo.Blogs", "User_UserName");
            AddForeignKey("dbo.Blogs", "User_UserName", "dbo.Users", "UserName");
        }
    }
}
