namespace FixSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buildings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameBuild = c.String(nullable: false),
                        Floor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fullname = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(maxLength: 10),
                        build = c.String(nullable: false, maxLength: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FixTests",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Building = c.String(),
                        Floor = c.Int(nullable: false),
                        Room = c.String(),
                        Details = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Rooms",
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
            DropTable("dbo.Rooms");
            DropTable("dbo.FixTests");
            DropTable("dbo.Employees");
            DropTable("dbo.Buildings");
        }
    }
}
