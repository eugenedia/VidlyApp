namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypesName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET NAME = 'Pay as You Go' WHERE  Id = 1");
            Sql("UPDATE MembershipTypes SET NAME = 'Monthly' WHERE  Id = 2");
            Sql("UPDATE MembershipTypes SET NAME = 'Quarterly' WHERE  Id = 3");
            Sql("UPDATE MembershipTypes SET NAME = 'Annually' WHERE  Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
