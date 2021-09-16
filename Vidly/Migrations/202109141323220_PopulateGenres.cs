namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("insert into dbo.genres (name) values('Comedy')");
            Sql("insert into dbo.genres (name) values('Action')");
            Sql("insert into dbo.genres (name) values('Family')");
            Sql("insert into dbo.genres (name) values('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
