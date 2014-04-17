namespace GenerateData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CountrySlug = c.String(nullable: false, maxLength: 100),
                        RegionSlug = c.String(nullable: false, maxLength: 100),
                        city = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "dbo.Configurations",
                c => new
                    {
                        CoonfigurationId = c.Int(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        LastUpdated = c.DateTime(nullable: false),
                        AccountId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Value = c.String(nullable: false),
                        RowsGenerated = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CoonfigurationId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        CountrySlug = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        RegionId = c.Int(nullable: false, identity: true),
                        CountrySlug = c.String(nullable: false, maxLength: 100),
                        Name = c.String(nullable: false, maxLength: 35),
                        ShortName = c.String(maxLength: 2),
                        RegionSlug = c.String(nullable: false, maxLength: 100),
                        Weight = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RegionId);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        SettingId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Value = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SettingId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Settings");
            DropTable("dbo.Regions");
            DropTable("dbo.Countries");
            DropTable("dbo.Configurations");
            DropTable("dbo.Cities");
        }
    }
}
