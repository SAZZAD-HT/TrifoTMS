namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Trip_Table_Insertion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        session = c.Int(nullable: false, identity: true),
                        Start = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.session);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trips");
        }
    }
}
