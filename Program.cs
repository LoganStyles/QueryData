class Program
{
    private static void Main(string[] args)
    {
        //data source
        List<Publisher> publishers =  new List<Publisher> 
                                        {
                                        new Publisher {Id=1, FirstName="Felix", LastName="Donald"},
                                        new Publisher {Id=2, FirstName="Sandra", LastName="Yemi"},
                                        new Publisher {Id=3, FirstName="Femi", LastName="Fraser"},
                                        new Publisher {Id=4, FirstName="Jones", LastName="Blaze"}
                                        };

        //data source
        List<Album> albums = new List<Album>
                                {
                                    new Album {Id=1, PublishId=2, Title="Gold Rush"},
                                    new Album {Id=2, PublishId=3, Title="My love"},
                                    new Album {Id=3, PublishId=3, Title="1000 miles"},
                                    new Album {Id=4, PublishId=2, Title="Sunny roses"}
                                };

        //cross join query between publishers and albums
        var albumPublisherQuery = publishers
                                            .SelectMany(pub=>albums,(pub,alb)=>new
                                            {
                                            PublisherName = pub.FirstName+" "+pub.LastName, 
                                            AlbumTitle  =alb.Title
                                            });
        

        Console.WriteLine("\tPUBLISHER \t\tALBUM");
        //execute the query
        foreach (var item in albumPublisherQuery)
        {
            Console.WriteLine("\t{0} -\t{1}", item.PublisherName, item.AlbumTitle);
        }

    }
}













