namespace GenerateData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConvertToFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "RegionId", c => c.Int(nullable: false));
            AddColumn("dbo.Regions", "CountryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cities", "RegionId");
            CreateIndex("dbo.Regions", "CountryId");
            AddForeignKey("dbo.Cities", "RegionId", "dbo.Regions", "RegionId", cascadeDelete: true);
            AddForeignKey("dbo.Regions", "CountryId", "dbo.Countries", "CountryId", cascadeDelete: true);
            DropColumn("dbo.Cities", "CountrySlug");
            DropColumn("dbo.Cities", "RegionSlug");
            DropColumn("dbo.Countries", "CountrySlug");
            DropColumn("dbo.Regions", "CountrySlug");
            DropColumn("dbo.Regions", "RegionSlug");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Regions", "RegionSlug", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Regions", "CountrySlug", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Countries", "CountrySlug", c => c.String(maxLength: 100));
            AddColumn("dbo.Cities", "RegionSlug", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Cities", "CountrySlug", c => c.String(nullable: false, maxLength: 100));
            DropForeignKey("dbo.Regions", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Cities", "RegionId", "dbo.Regions");
            DropIndex("dbo.Regions", new[] { "CountryId" });
            DropIndex("dbo.Cities", new[] { "RegionId" });
            DropColumn("dbo.Regions", "CountryId");
            DropColumn("dbo.Cities", "RegionId");
        }
    }
}
