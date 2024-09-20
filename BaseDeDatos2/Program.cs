// See https://aka.ms/new-console-template for more information

using BaseDeDatos2;
using System.Data.SqlClient;

try
{
    BeerDB beerDB = new BeerDB(".", "CsharpDB", "sa", "Inchcape@2023<");
    List<Beer> beers = beerDB.GetAll();

    foreach(var beer in beers)
    {
        Console.WriteLine(beer.Name);
    }
}
catch (SqlException ex)
{
    Console.WriteLine("No pudimos conectarnos. " + ex.Message);
}