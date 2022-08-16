using QueryData;

class Program
{
    private static void Main(string[] args)
    {
        var context = new ArtistsContext();

        var posts = context.Posts.ToList();

        foreach (var item in posts)
        {
            Console.WriteLine($"Post id : {item.PostId}, Post Title: {item.Title}");
        }
    }
}
