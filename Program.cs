﻿class Program
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
                                    new Album {Id=1, PublisherId=2, Title="Gold Rush"},
                                    new Album {Id=2, PublisherId=3, Title="My love"},
                                    new Album {Id=3, PublisherId=3, Title="1000 miles"},
                                    new Album {Id=4, PublisherId=2, Title="Sunny roses"}
                                };

        //group join query between publishers and albums
        var albumPublisherQuery = publishers
                                            .GroupJoin(albums,p=>p.Id, a=>a.PublisherId, 
                                            (pub,albs)=>new
                                                    {
                                                    PublisherName = pub.FirstName+" "+pub.LastName, 
                                                    Albums  =albs.Count()
                                                    });
        

        Console.WriteLine("\tPUBLISHER \tALBUMS");
        //execute the query
        foreach (var item in albumPublisherQuery)
        {
            Console.WriteLine("\t{0} \t{1}", item.PublisherName, item.Albums);
        }

    }
}
