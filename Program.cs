using Microsoft.EntityFrameworkCore;
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

        //disable query filters
        var postsWithDisabledFilters = context.Posts.IgnoreQueryFilters().ToList();

        foreach (var item in postsWithDisabledFilters)
        {
            Console.WriteLine($"Post id : {item.PostId}, Post Title: {item.Title}");
        }

    }
}
