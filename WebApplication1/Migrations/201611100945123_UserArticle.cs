namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserArticle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArticleUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArticleId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articles", t => t.ArticleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.ArticleId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArticleUsers", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.ArticleUsers", "ArticleId", "dbo.Articles");
            DropIndex("dbo.ArticleUsers", new[] { "UserId" });
            DropIndex("dbo.ArticleUsers", new[] { "ArticleId" });
            DropTable("dbo.ArticleUsers");
        }
    }
}
