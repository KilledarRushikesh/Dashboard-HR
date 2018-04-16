namespace ThinkBridge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeamDetails",
                c => new
                    {
                        TeamsDetailsId = c.Int(nullable: false, identity: true),
                        TeamName = c.String(nullable: false),
                        TeamLeader = c.String(),
                        ProjectLead = c.String(),
                    })
                .PrimaryKey(t => t.TeamsDetailsId);
            
            AddColumn("dbo.TeamMembers", "TeamDetails_TeamsDetailsId", c => c.Int());
            CreateIndex("dbo.TeamMembers", "TeamDetails_TeamsDetailsId");
            AddForeignKey("dbo.TeamMembers", "TeamDetails_TeamsDetailsId", "dbo.TeamDetails", "TeamsDetailsId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamMembers", "TeamDetails_TeamsDetailsId", "dbo.TeamDetails");
            DropIndex("dbo.TeamMembers", new[] { "TeamDetails_TeamsDetailsId" });
            DropColumn("dbo.TeamMembers", "TeamDetails_TeamsDetailsId");
            DropTable("dbo.TeamDetails");
        }
    }
}
