namespace Summer_School_Jan20.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changes : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Movies");
            AddColumn("dbo.Movies", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Movies", "Surname", c => c.String());
            AddColumn("dbo.Movies", "CreanType", c => c.String());
            AddColumn("dbo.Movies", "Time", c => c.String());
            AddColumn("dbo.Movies", "numOfParking", c => c.Double(nullable: false));
            AddColumn("dbo.Movies", "Parking", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Discount", c => c.Double(nullable: false));
            AlterColumn("dbo.Movies", "total", c => c.Double(nullable: false));
            AddPrimaryKey("dbo.Movies", "Id");
            DropColumn("dbo.Movies", "MovieId");
            DropColumn("dbo.Movies", "MovieName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "MovieName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Movies", "MovieId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.Movies", "total", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "Discount");
            DropColumn("dbo.Movies", "Parking");
            DropColumn("dbo.Movies", "numOfParking");
            DropColumn("dbo.Movies", "Time");
            DropColumn("dbo.Movies", "CreanType");
            DropColumn("dbo.Movies", "Surname");
            DropColumn("dbo.Movies", "Id");
            AddPrimaryKey("dbo.Movies", "MovieId");
        }
    }
}
