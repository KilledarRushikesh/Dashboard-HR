namespace ThinkBridge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDatabase21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeamMembers", "InsuaranceByCompany", c => c.Boolean(nullable: false));
            AddColumn("dbo.TeamMembers", "PFUANNumber", c => c.String(nullable: false));
            AlterColumn("dbo.TeamMembers", "DOB", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TeamMembers", "DOB", c => c.DateTime());
            DropColumn("dbo.TeamMembers", "PFUANNumber");
            DropColumn("dbo.TeamMembers", "InsuaranceByCompany");
        }
    }
}
