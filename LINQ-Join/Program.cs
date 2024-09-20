// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.Linq;

var beers = new List<Beer>()
{
    new Beer()
    {
        Name="Corona", Country="México"
    },
    new Beer()
    {
        Name="Delirium", Country="Bélgica"
    },
    new Beer()
    {
        Name="Erdinger", Country="Alemania"
    },
    new Beer()
    {
        Name="Minerva", Country="México"
    }
};

var countries = new List<Country>()
{
    new Country()
    {
        Name="México", Continent="América"
    },
    new Country()
    {
        Name="Bélgica", Continent="Europa"
    },
    new Country()
    {
        Name="Alemania", Continent="Europa"
    },
    new Country()
    {
        Name="Uruguay", Continent="América"
    }
};

var beerWithContinent = from b in beers
                        join pais in countries
                        on b.Country equals pais.Name
                        select new
                        {
                            Name = b.Name,
                            Country = b.Country,
                            Continent = pais.Continent
                        };

foreach(var beer in beerWithContinent)
{
    Console.WriteLine($"{beer.Name} {beer.Country} {beer.Continent}");
}

public class Beer
{
    public string Name { get; set; }
    public string Country { get; set; }

}

public class Country
{
    public string Name { get; set; }
    public string Continent { get; set; }
}
