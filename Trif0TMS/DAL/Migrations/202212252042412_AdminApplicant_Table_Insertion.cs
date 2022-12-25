namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminApplicant_Table_Insertion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminApplicants",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Firstame = c.String(nullable: false),
                        Lastname = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AdminApplicants");
        }
    }
}
