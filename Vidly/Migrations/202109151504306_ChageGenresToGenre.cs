namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChageGenresToGenre : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "GenresId", newName: "GenreId");
            RenameIndex(table: "dbo.Movies", name: "IX_GenresId", newName: "IX_GenreId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Movies", name: "IX_GenreId", newName: "IX_GenresId");
            RenameColumn(table: "dbo.Movies", name: "GenreId", newName: "GenresId");
        }
    }
}
