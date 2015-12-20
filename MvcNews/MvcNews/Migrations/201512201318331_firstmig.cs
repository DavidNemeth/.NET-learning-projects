namespace MvcNews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tittle = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Body = c.String(nullable: false),
                        Published = c.Boolean(nullable: false),
                        PostedDate = c.DateTime(nullable: false),
                        Modified = c.DateTime(),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.PostTag",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PostTagNews",
                c => new
                    {
                        PostTag_Id = c.Int(nullable: false),
                        News_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PostTag_Id, t.News_Id })
                .ForeignKey("dbo.PostTag", t => t.PostTag_Id, cascadeDelete: true)
                .ForeignKey("dbo.News", t => t.News_Id, cascadeDelete: true)
                .Index(t => t.PostTag_Id)
                .Index(t => t.News_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostTagNews", "News_Id", "dbo.News");
            DropForeignKey("dbo.PostTagNews", "PostTag_Id", "dbo.PostTag");
            DropForeignKey("dbo.News", "Category_Id", "dbo.Category");
            DropIndex("dbo.PostTagNews", new[] { "News_Id" });
            DropIndex("dbo.PostTagNews", new[] { "PostTag_Id" });
            DropIndex("dbo.News", new[] { "Category_Id" });
            DropTable("dbo.PostTagNews");
            DropTable("dbo.PostTag");
            DropTable("dbo.News");
            DropTable("dbo.Category");
        }
    }
}