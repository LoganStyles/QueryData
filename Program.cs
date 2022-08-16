using Microsoft.EntityFrameworkCore;
using QueryData;

class Program
{
    private static void Main(string[] args)
    {
        var context = new ArtistsContext();

        // var blogs = context.Blogs.Include(blog => blog.Posts).AsSplitQuery().ToList();
        var blogs = context.Blogs.Include(blog => blog.Posts).ToList();

        foreach (var item in blogs)
        {
            Console.WriteLine(item.BlogId);

            foreach(var post in item.Posts){
                Console.WriteLine(post.Title);
            }
        }
    }
}
