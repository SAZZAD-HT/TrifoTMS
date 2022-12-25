namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updated_Token_Table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tokens", "Username", c => c.String(nullable: false));
            DropColumn("dbo.Tokens", "Email");
            DropColumn("dbo.Tokens", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tokens", "Type", c => c.String(nullable: false));
            AddColumn("dbo.Tokens", "Email", c => c.String(nullable: false));
            DropColumn("dbo.Tokens", "Username");
        }
    }
}
