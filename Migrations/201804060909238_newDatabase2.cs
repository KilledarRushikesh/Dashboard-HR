namespace ThinkBridge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDatabase2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TeamMembers", "EmployeeStatus", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TeamMembers", "EmployeeStatus", c => c.String(nullable: false));
        }
    }
}
