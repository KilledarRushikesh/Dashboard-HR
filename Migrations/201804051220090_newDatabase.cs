namespace ThinkBridge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TeamMembers", "DOB", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TeamMembers", "DOB", c => c.DateTime(nullable: false));
        }
    }
}
