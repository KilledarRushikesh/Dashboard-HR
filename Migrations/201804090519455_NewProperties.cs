namespace ThinkBridge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeamMembers", "MedicalInsuaranceByThinkbridge", c => c.Boolean(nullable: false));
            AddColumn("dbo.TeamMembers", "PFNumber", c => c.String(nullable: false));
            AddColumn("dbo.TeamMembers", "Education", c => c.String(nullable: false));
            AddColumn("dbo.TeamMembers", "Hike", c => c.String(nullable: false));
            AddColumn("dbo.TeamMembers", "FatherOrHusbandName", c => c.String(nullable: false));
            AddColumn("dbo.TeamMembers", "TraineeReviewMonth", c => c.String());
            AddColumn("dbo.TeamMembers", "JoineeProbationReview", c => c.String());
            AddColumn("dbo.TeamMembers", "Gender", c => c.String(nullable: false));
            AddColumn("dbo.TeamMembers", "PassportExpiry", c => c.DateTime());
            AddColumn("dbo.TeamMembers", "AadharNumber", c => c.String());
            AddColumn("dbo.TeamMembers", "BankName", c => c.String());
            AddColumn("dbo.TeamMembers", "AccountNumber", c => c.String());
            AddColumn("dbo.TeamMembers", "MaritalStatus", c => c.String());
            AddColumn("dbo.TeamMembers", "InsuranceDeletion", c => c.Boolean(nullable: false));
            AlterColumn("dbo.TeamMembers", "DOB", c => c.DateTime());
            AlterColumn("dbo.TeamMembers", "WeddingAnniversary", c => c.DateTime());
            DropColumn("dbo.TeamMembers", "InsuaranceByCompany");
            DropColumn("dbo.TeamMembers", "PFUANNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TeamMembers", "PFUANNumber", c => c.String(nullable: false));
            AddColumn("dbo.TeamMembers", "InsuaranceByCompany", c => c.Boolean(nullable: false));
            AlterColumn("dbo.TeamMembers", "WeddingAnniversary", c => c.String());
            AlterColumn("dbo.TeamMembers", "DOB", c => c.DateTime(nullable: false));
            DropColumn("dbo.TeamMembers", "InsuranceDeletion");
            DropColumn("dbo.TeamMembers", "MaritalStatus");
            DropColumn("dbo.TeamMembers", "AccountNumber");
            DropColumn("dbo.TeamMembers", "BankName");
            DropColumn("dbo.TeamMembers", "AadharNumber");
            DropColumn("dbo.TeamMembers", "PassportExpiry");
            DropColumn("dbo.TeamMembers", "Gender");
            DropColumn("dbo.TeamMembers", "JoineeProbationReview");
            DropColumn("dbo.TeamMembers", "TraineeReviewMonth");
            DropColumn("dbo.TeamMembers", "FatherOrHusbandName");
            DropColumn("dbo.TeamMembers", "Hike");
            DropColumn("dbo.TeamMembers", "Education");
            DropColumn("dbo.TeamMembers", "PFNumber");
            DropColumn("dbo.TeamMembers", "MedicalInsuaranceByThinkbridge");
        }
    }
}
