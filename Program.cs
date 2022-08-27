using System.Globalization;

class Program
{
    private static void Main(string[] args)
    {
        //data source
        List<Album> albums = new List<Album>
        {
            new Album {Id = 1,  Title = "Gold Rush", Price=3200, ReleaseDate=new DateOnly(2020, 04, 20)},
            new Album {Id = 2,  Title = "My love", Price=4800, ReleaseDate=new DateOnly(1998, 07, 20)},
            new Album {Id = 3,  Title = "1000 miles", Price=5000, ReleaseDate=new DateOnly(2020, 09, 30)},
            new Album {Id = 4,  Title = "Sunny roses", Price=6500, ReleaseDate=new DateOnly(2022, 01, 10)},
            new Album {Id = 5,  Title = "Riot act", Price=1000, ReleaseDate=new DateOnly(2020, 02, 07)},
            new Album {Id = 6,  Title = "True confessions", Price=2000, ReleaseDate=new DateOnly(2015, 12, 15)},
            new Album {Id = 7,  Title = "Earth and firestorms", Price=3500, ReleaseDate=new DateOnly(2001, 11, 11)},
            new Album {Id = 8,  Title = "Rekindle my heart", Price=4400, ReleaseDate=new DateOnly(2022, 12, 03)},
            new Album {Id = 9,  Title = "The invincible hand", Price=9000, ReleaseDate=new DateOnly(2005, 05, 20)},
            new Album {Id = 10,  Title = "Born without you", Price=3000, ReleaseDate=new DateOnly(2006, 11, 20)}
        };


        Console.WriteLine("FIRST ALBUM TITLE \t\tRELEASE DATE");

        var firstAlbum = albums.First();
        Console.WriteLine(
                "{0} \t\t\t{1}",
                firstAlbum.Title,
                firstAlbum.ReleaseDate.ToString("dd MMM, yyyy", CultureInfo.InvariantCulture)
            );

        var firstAlbumOrderedbyDate = albums
                                        .OrderBy(a => a.ReleaseDate)
                                        .First();
        Console.WriteLine(
                "{0} \t\t\t{1}",
                firstAlbumOrderedbyDate.Title,
                firstAlbumOrderedbyDate.ReleaseDate.ToString("dd MMM, yyyy", CultureInfo.InvariantCulture)
            );

        var firstOrDefaultAlbumOrderedbyDate = albums
                                                .OrderBy(a => a.ReleaseDate)
                                                .FirstOrDefault();
        Console.WriteLine(
                "{0} \t\t\t{1}",
                firstOrDefaultAlbumOrderedbyDate.Title,
                firstOrDefaultAlbumOrderedbyDate.ReleaseDate.ToString("dd MMM, yyyy", CultureInfo.InvariantCulture)
            );

        var firstOrDefaultAlbumOrderedbyDateHavingHighPrice = albums
                                                                .OrderBy(a => a.ReleaseDate)
                                                                .FirstOrDefault(a => a.Price > 5000);
        Console.WriteLine(
                "{0} \t\t{1}",
                firstOrDefaultAlbumOrderedbyDateHavingHighPrice.Title,
                firstOrDefaultAlbumOrderedbyDateHavingHighPrice.ReleaseDate.ToString("dd MMM, yyyy", CultureInfo.InvariantCulture)
            );
    }
}
