// See https://aka.ms/new-console-template for more information

var daniel = new
{
    Name = "Dani",
    Country = "Col"
};

Console.WriteLine($"{daniel.Name} es de {daniel.Country}");

// Los objetos anonimos no se pueden modificar, ya que son read only.

var beers = new[]
{
    new { name = "Red", brand = "Delirium"},
    new { name = "London Porter", brand = "Fullers"}
};

foreach (var beer in beers)
{
    Console.WriteLine($"Cerveza {beer.name} de {beer.brand}");
};