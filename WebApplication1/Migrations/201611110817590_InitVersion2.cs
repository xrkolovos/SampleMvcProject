namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitVersion2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Articles", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Articles", new[] { "CategoryId" });
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
            
            AddColumn("dbo.Articles", "Description", c => c.String());
            AddColumn("dbo.Articles", "DateTimeCreated", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Articles", "DateTimePublished", c => c.DateTimeOffset(precision: 7));
            AddColumn("dbo.Articles", "AuthorId", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "Fullname", c => c.String(maxLength: 800));
            AddColumn("dbo.AspNetUsers", "Addresss", c => c.String(maxLength: 500));
            AddColumn("dbo.AspNetUsers", "Hometown", c => c.String(maxLength: 200));
            AddColumn("dbo.AspNetUsers", "County", c => c.String(maxLength: 200));
            AlterColumn("dbo.Articles", "CategoryId", c => c.Int());
            CreateIndex("dbo.Articles", "CategoryId");
            CreateIndex("dbo.Articles", "AuthorId");
            AddForeignKey("dbo.Articles", "AuthorId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Articles", "CategoryId", "dbo.Categories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articles", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Articles", "AuthorId", "dbo.AspNetUsers");
            DropForeignKey("dbo.ArticleUsers", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.ArticleUsers", "ArticleId", "dbo.Articles");
            DropIndex("dbo.ArticleUsers", new[] { "UserId" });
            DropIndex("dbo.ArticleUsers", new[] { "ArticleId" });
            DropIndex("dbo.Articles", new[] { "AuthorId" });
            DropIndex("dbo.Articles", new[] { "CategoryId" });
            AlterColumn("dbo.Articles", "CategoryId", c => c.Int(nullable: false));
            DropColumn("dbo.AspNetUsers", "County");
            DropColumn("dbo.AspNetUsers", "Hometown");
            DropColumn("dbo.AspNetUsers", "Addresss");
            DropColumn("dbo.AspNetUsers", "Fullname");
            DropColumn("dbo.Articles", "AuthorId");
            DropColumn("dbo.Articles", "DateTimePublished");
            DropColumn("dbo.Articles", "DateTimeCreated");
            DropColumn("dbo.Articles", "Description");
            DropTable("dbo.ArticleUsers");
            CreateIndex("dbo.Articles", "CategoryId");
            AddForeignKey("dbo.Articles", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
    }
}
