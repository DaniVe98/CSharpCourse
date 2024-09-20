// See https://aka.ms/new-console-template for more information

using System.Text.Json;

Beer myBeer = new Beer()
{
    Name = "Cola y Pola",
    Brand = "Bavaria"
};

Beer[] beers = new Beer[]
{
    new Beer()
    {
        Name = "Cola y Pola",
        Brand = "Bavaria"
    },
    new Beer()
    {
        Name = "Poker",
        Brand = "Águila"
    }
};

//string json = "{\"Name\": \"Cola y Pola\", \"Brand\": \"Bavaria\"}";
string json = JsonSerializer.Serialize(myBeer);
string json2 = JsonSerializer.Serialize(beers);
Beer beer = JsonSerializer.Deserialize<Beer>(json);
Beer[] beers2 = JsonSerializer.Deserialize<Beer[]>(json2);



//string json2 = "[" + "{\"Name\": \"Cola y Pola\", \"Brand\": \"Bavaria\"}," + "{\"Name\": \"Poker\", \"Brand\": \"Águila\"}" + "]";


public class Beer
{
public string Name {  get; set; }
public string Brand { get; set; }

}