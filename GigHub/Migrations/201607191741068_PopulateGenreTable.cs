namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) Values ( 1, 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) Values ( 2, 'Blues')");
            Sql("INSERT INTO Genres (Id, Name) Values ( 3, 'Rock')");
            Sql("INSERT INTO Genres (Id, Name) Values ( 4, 'Ccountry')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id in (1,2,3,4)");
        }
    }
}
