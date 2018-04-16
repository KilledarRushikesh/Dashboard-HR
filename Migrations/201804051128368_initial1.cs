namespace ThinkBridge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeamMembers", "EmployeeStatus", c => c.String(nullable: false));
            AddColumn("dbo.TeamMembers", "Designation", c => c.String(nullable: false));
            AddColumn("dbo.TeamMembers", "JoiningDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.TeamMembers", "PreviousExperience", c => c.String(nullable: false));
            AddColumn("dbo.TeamMembers", "CTC", c => c.String(nullable: false));
            AddColumn("dbo.TeamMembers", "EarlierSalary", c => c.String(nullable: false));
            AddColumn("dbo.TeamMembers", "CurrentExperience", c => c.String(nullable: false));
            AddColumn("dbo.TeamMembers", "CompanyAssetDetails", c => c.String(nullable: false));
            AddColumn("dbo.TeamMembers", "SalaryReviewMonth", c => c.String(nullable: false));
            AddColumn("dbo.TeamMembers", "LocalAddress", c => c.String());
            AddColumn("dbo.TeamMembers", "PermanantAddress", c => c.String());
            AddColumn("dbo.TeamMembers", "PAN", c => c.String());
            AddColumn("dbo.TeamMembers", "PassportNumber", c => c.String());
            AddColumn("dbo.TeamMembers", "DOB", c => c.DateTime(nullable: true));
            AddColumn("dbo.TeamMembers", "EmergencyContact", c => c.String());
            AddColumn("dbo.TeamMembers", "SpouseName", c => c.String());
            AddColumn("dbo.TeamMembers", "SpouseDOB", c => c.String());
            AddColumn("dbo.TeamMembers", "ChildName", c => c.String());
            AddColumn("dbo.TeamMembers", "ChildDOB", c => c.String());
            AddColumn("dbo.TeamMembers", "WeddingAnniversary", c => c.String());
            AddColumn("dbo.TeamMembers", "TerminationDate", c => c.String());
            AddColumn("dbo.TeamMembers", "TerminationFeedback", c => c.String());
            AddColumn("dbo.TeamMembers", "TerminationReason", c => c.String());
            AlterColumn("dbo.TeamMembers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.TeamMembers", "MobileNumber", c => c.String(nullable: false));
            AlterColumn("dbo.TeamMembers", "TeamName", c => c.String(nullable: false));
            AlterColumn("dbo.TeamMembers", "EmailId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TeamMembers", "EmailId", c => c.String());
            AlterColumn("dbo.TeamMembers", "TeamName", c => c.String());
            AlterColumn("dbo.TeamMembers", "MobileNumber", c => c.String());
            AlterColumn("dbo.TeamMembers", "Name", c => c.String());
            DropColumn("dbo.TeamMembers", "TerminationReason");
            DropColumn("dbo.TeamMembers", "TerminationFeedback");
            DropColumn("dbo.TeamMembers", "TerminationDate");
            DropColumn("dbo.TeamMembers", "WeddingAnniversary");
            DropColumn("dbo.TeamMembers", "ChildDOB");
            DropColumn("dbo.TeamMembers", "ChildName");
            DropColumn("dbo.TeamMembers", "SpouseDOB");
            DropColumn("dbo.TeamMembers", "SpouseName");
            DropColumn("dbo.TeamMembers", "EmergencyContact");
            DropColumn("dbo.TeamMembers", "DOB");
            DropColumn("dbo.TeamMembers", "PassportNumber");
            DropColumn("dbo.TeamMembers", "PAN");
            DropColumn("dbo.TeamMembers", "PermanantAddress");
            DropColumn("dbo.TeamMembers", "LocalAddress");
            DropColumn("dbo.TeamMembers", "SalaryReviewMonth");
            DropColumn("dbo.TeamMembers", "CompanyAssetDetails");
            DropColumn("dbo.TeamMembers", "CurrentExperience");
            DropColumn("dbo.TeamMembers", "EarlierSalary");
            DropColumn("dbo.TeamMembers", "CTC");
            DropColumn("dbo.TeamMembers", "PreviousExperience");
            DropColumn("dbo.TeamMembers", "JoiningDate");
            DropColumn("dbo.TeamMembers", "Designation");
            DropColumn("dbo.TeamMembers", "EmployeeStatus");
        }
    }
}
