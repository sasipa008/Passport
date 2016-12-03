namespace FixSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewRooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        room = c.String(nullable: false),
                        NameBuild = c.String(nullable: false),
                        Floor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewRooms");
        }
    }
}
