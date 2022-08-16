using Microsoft.EntityFrameworkCore;
using QueryData;

class Program
{
    private static void Main(string[] args)
    {
        var context = new ArtistsContext();

        var blogs = context.Blogs.FromSqlRaw("select * from Blogs").ToList();

        foreach (var item in blogs)
        {
            Console.WriteLine(item.BlogId);
        }
    }
}
