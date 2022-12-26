namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fare_Table_Insertion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fares",
                c => new
                    {
                        Route_Id = c.Int(nullable: false, identity: true),
                        Distance = c.Int(nullable: false),
                        Fare1 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Route_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fares");
        }
    }
}
