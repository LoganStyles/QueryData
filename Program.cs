class Program
{
    private static void Main(string[] args)
    {
        //data source
        List<Publisher> publishers = new List<Publisher>
        {
            new Publisher {Id = 1, FirstName = "Felix",LastName = "Donald"},
            new Publisher {Id = 2, FirstName = "Sandra",LastName = "Yemi"},
            new Publisher {Id = 3, FirstName = "Femi",LastName = "Fraser"},
            new Publisher {Id = 4, FirstName = "Jones",LastName = "Blaze"}
        };

        //data source
        List<Album> albums = new List<Album>
        {
            new Album {Id = 1, PublisherId = 2, Title = "Gold Rush"},
            new Album {Id = 2, PublisherId = 3, Title = "My love"},
            new Album {Id = 3, PublisherId = 3, Title = "1000 miles"},
            new Album {Id = 4, PublisherId = 2, Title = "Sunny roses"}
        };

        //non-equijoin query between albums and publishers
        var existingPublisherIds = from alb in albums select alb.PublisherId;

        var noAlbumPublisherQuery = from pub in publishers
                                        where !existingPublisherIds.Contains(pub.Id)
                                        select new { PublisherName = pub.LastName + " " + pub.FirstName };
        

        Console.WriteLine("PUBLISHERS WITHOUT ALBUMS");
        //execute the query
        foreach (var item in noAlbumPublisherQuery)
        {
            Console.WriteLine("{0} ", item.PublisherName);
        }
    }
}
