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

        //sum the prices for all albums released in a specified year
        var selectedDate = new DateOnly(2020,1,1);
        var sumSelectedAlbums = albums
                                .Where(a => a.ReleaseDate < selectedDate)
                                .Sum(a => a.Price);

        //output the result
        Console.WriteLine(" The total prices for all albums released before {0} is {1} ", 
                            selectedDate.ToString("yyyy",CultureInfo.InvariantCulture),
                            sumSelectedAlbums);
        
    }
}
