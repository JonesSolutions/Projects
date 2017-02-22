namespace NMHASurvey.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nmug : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Surveys", "otherPayerName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Surveys", "otherPayerName", c => c.String());
        }
    }
}
