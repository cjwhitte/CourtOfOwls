﻿Console.WriteLine("Hello World");

var country = DataBaseClient.CountryCollection.Find(
    Builders<Country>.Filter.Exists(x => x.Id)
).ToList();


foreach(var i in country)
{
    if(i.Name.Contains("Sudan"))
        Console.WriteLine(i.CountryCode + " " + i.Name);
    if(i.Name.Contains("Serbia"))
        Console.WriteLine(i.CountryCode + " " + i.Name);
    if(i.Name.Contains("Kosovo"))
        Console.WriteLine(i.CountryCode + " " + i.Name);
}

var rng = new Random();



var filter = Builders<Country>.Filter.Eq(x => x.Name, "Sudan");

var update = Builders<Country>.Update.Set(x => x.Name, "S. Sudan");

await DataBaseClient.CountryCollection.UpdateOneAsync(filter, update);

