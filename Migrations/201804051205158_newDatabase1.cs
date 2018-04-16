namespace ThinkBridge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDatabase1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeamMembers", "TeamMemberID", c => c.Int(nullable: false));
            AddColumn("dbo.TeamMembers", "EmployeeID", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TeamMembers", "EmployeeID");
            DropColumn("dbo.TeamMembers", "TeamMemberID");
        }
    }
}
