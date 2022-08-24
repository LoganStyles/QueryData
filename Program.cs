using Microsoft.EntityFrameworkCore;
using QueryData;

class Program
{
    private static void Main(string[] args)
    {
        var context = new ArtistsContext();

        var albums = context.Albums.ToList();

        foreach (var album in albums)
        {
            Console.WriteLine($"Album id : {album.Id}, Album Title: {album.Title}");
        }

        //disable query filters
        var albumsWithDisabledFilters = context.Albums.IgnoreQueryFilters().ToList();

        foreach (var album in albumsWithDisabledFilters)
        {
            Console.WriteLine($"Album id : {album.Id}, Album Title: {album.Title}");
        }

    }
}
