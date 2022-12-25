namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updated_AdminApplicant_Table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdminApplicants", "Firstname", c => c.String(nullable: false));
            DropColumn("dbo.AdminApplicants", "Firstame");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AdminApplicants", "Firstame", c => c.String(nullable: false));
            DropColumn("dbo.AdminApplicants", "Firstname");
        }
    }
}
