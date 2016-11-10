namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Fullname", c => c.String(maxLength: 800));
            AddColumn("dbo.AspNetUsers", "Addresss", c => c.String(maxLength: 500));
            AddColumn("dbo.AspNetUsers", "Hometown", c => c.String(maxLength: 200));
            AddColumn("dbo.AspNetUsers", "County", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "County");
            DropColumn("dbo.AspNetUsers", "Hometown");
            DropColumn("dbo.AspNetUsers", "Addresss");
            DropColumn("dbo.AspNetUsers", "Fullname");
        }
    }
}
