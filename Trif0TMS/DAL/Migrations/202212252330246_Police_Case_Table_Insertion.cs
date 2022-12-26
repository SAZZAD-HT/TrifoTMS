namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Police_Case_Table_Insertion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cases",
                c => new
                    {
                        C_Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                        Posting = c.String(nullable: false),
                        Time = c.DateTime(nullable: false),
                        Fine = c.String(nullable: false),
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.C_Id)
                .ForeignKey("dbo.Police", t => t.ID, cascadeDelete: true)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Police",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 50),
                        Posting = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cases", "ID", "dbo.Police");
            DropIndex("dbo.Cases", new[] { "ID" });
            DropTable("dbo.Police");
            DropTable("dbo.Cases");
        }
    }
}
