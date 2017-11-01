namespace DatabaseBlogProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteredUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Blogs", "User_UserId", "dbo.Users");
            DropIndex("dbo.Blogs", new[] { "User_UserId" });
            RenameColumn(table: "dbo.Blogs", name: "User_UserId", newName: "UserId");
            AlterColumn("dbo.Blogs", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Blogs", "UserId");
            AddForeignKey("dbo.Blogs", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blogs", "UserId", "dbo.Users");
            DropIndex("dbo.Blogs", new[] { "UserId" });
            AlterColumn("dbo.Blogs", "UserId", c => c.Int());
            RenameColumn(table: "dbo.Blogs", name: "UserId", newName: "User_UserId");
            CreateIndex("dbo.Blogs", "User_UserId");
            AddForeignKey("dbo.Blogs", "User_UserId", "dbo.Users", "UserId");
        }
    }
}
