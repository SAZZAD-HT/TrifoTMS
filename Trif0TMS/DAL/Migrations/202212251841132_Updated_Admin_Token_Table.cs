namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updated_Admin_Token_Table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "Name", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Admins", "Email", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Admins", "Phone", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Admins", "Address", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Tokens", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Tokens", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Admins", "Password", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Admins", "Username");
            DropColumn("dbo.Tokens", "Username");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tokens", "Username", c => c.String(nullable: false));
            AddColumn("dbo.Admins", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Admins", "Password", c => c.String(nullable: false));
            DropColumn("dbo.Tokens", "Type");
            DropColumn("dbo.Tokens", "Email");
            DropColumn("dbo.Admins", "Address");
            DropColumn("dbo.Admins", "Phone");
            DropColumn("dbo.Admins", "Email");
            DropColumn("dbo.Admins", "Name");
        }
    }
}
