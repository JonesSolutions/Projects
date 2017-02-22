namespace NMHASurvey.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hospitals",
                c => new
                    {
                        hospitalId = c.Int(nullable: false, identity: true),
                        hospitalName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.hospitalId);
            
            CreateTable(
                "dbo.Payers",
                c => new
                    {
                        payerId = c.Int(nullable: false, identity: true),
                        payerName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.payerId);
            
            CreateTable(
                "dbo.Surveys",
                c => new
                    {
                        surveyId = c.Int(nullable: false, identity: true),
                        submitDate = c.DateTime(nullable: false),
                        payerId = c.Int(nullable: false),
                        hospitalId = c.Int(nullable: false),
                        contactName = c.String(nullable: false),
                        contactEmail = c.String(nullable: false),
                        contactPhone = c.String(nullable: false),
                        description = c.String(nullable: false, maxLength: 500),
                        mcoResponse = c.String(nullable: false, maxLength: 500),
                        claimNumbers = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.surveyId)
                .ForeignKey("dbo.Hospitals", t => t.hospitalId, cascadeDelete: true)
                .ForeignKey("dbo.Payers", t => t.payerId, cascadeDelete: true)
                .Index(t => t.payerId)
                .Index(t => t.hospitalId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Surveys", "payerId", "dbo.Payers");
            DropForeignKey("dbo.Surveys", "hospitalId", "dbo.Hospitals");
            DropIndex("dbo.Surveys", new[] { "hospitalId" });
            DropIndex("dbo.Surveys", new[] { "payerId" });
            DropTable("dbo.Surveys");
            DropTable("dbo.Payers");
            DropTable("dbo.Hospitals");
        }
    }
}
