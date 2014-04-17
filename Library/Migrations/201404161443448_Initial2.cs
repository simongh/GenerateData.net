namespace GenerateData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Cities", name: "city", newName: "Name");
            RenameColumn(table: "dbo.Configurations", name: "CoonfigurationId", newName: "ConfigurationId");
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountId = c.Int(nullable: false, identity: true),
                        DateCreated = c.DateTime(nullable: false),
                        LastUpdated = c.DateTime(nullable: false),
                        LastLogin = c.DateTime(nullable: false),
                        DateExpires = c.DateTime(nullable: false),
                        AccountType = c.Int(nullable: false),
                        Firstname = c.String(maxLength: 50),
                        Lastname = c.String(maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 50),
                        RecoveryQuestion = c.String(maxLength: 100),
                        RecoveryAnswer = c.String(maxLength: 100),
                        RowsGenerated = c.Int(nullable: false),
                        MaxRecords = c.Int(),
                    })
                .PrimaryKey(t => t.AccountId);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        SessionId = c.Int(nullable: false, identity: true),
                        Key = c.String(nullable: false, maxLength: 100),
                        Data = c.String(),
                        Expires = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SessionId);
            
            AlterColumn("dbo.Settings", "Value", c => c.String());
            CreateIndex("dbo.Settings", "Name", unique: true, name: "IX_Settings_Name");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Settings", "IX_Settings_Name");
            AlterColumn("dbo.Settings", "Value", c => c.String(nullable: false));
            DropTable("dbo.Sessions");
            DropTable("dbo.Accounts");
            RenameColumn(table: "dbo.Configurations", name: "ConfigurationId", newName: "CoonfigurationId");
            RenameColumn(table: "dbo.Cities", name: "Name", newName: "city");
        }
    }
}
