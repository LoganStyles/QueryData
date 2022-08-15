using QueryData;

class Program
{
    private static void Main(string[] args)
    {
        var context = new ArtistsContext();

        //fetching all artists
        var artists = context.Employees.ToList();

        Console.WriteLine();
        foreach (var artist in artists)
        {
            Console.WriteLine("{0} has the following album(s).", artist.LastName);

            foreach (var album in artist.Albums)
            {
                Console.WriteLine("{0} ", album.Title);
            }
            Console.WriteLine();
        }
    }
}
