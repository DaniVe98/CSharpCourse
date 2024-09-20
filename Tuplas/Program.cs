// See https://aka.ms/new-console-template for more information

(int id, string name) product = (1, "cerveza stout");

Console.WriteLine($"{product.id} {product.name}");

// La tuplas si son editables, diferentes a los tipos anonimos que son read only

product.name = "cerveza porter";
Console.WriteLine($"{product.id} {product.name}");

// Aca podemos ver una tupla, en donde ya al darle 1 se entiende que es un int y Daniel un string:
var person = (1, "Daniel");
Console.WriteLine($"persona {person.Item1} es {person.Item2}");

var people = new[]
{
    (1, "Juan"),
    (2, "Cris"),
    (3, "Zara")
};

foreach(var p in people)
{
    Console.WriteLine($"{p.Item1} {p.Item2}");
}

(int id, string name)[] people2 = new[]
{
    (4, "Santiago"),
    (5, "Maria"),
    (6, "Cesar")
};

foreach (var p2 in people2)
{
    Console.WriteLine($"{p2.id} {p2.name}");
}

var cityInfo = getLocationCDMX();
Console.WriteLine($"lat: {cityInfo.lat}; long: {cityInfo.lng}; nombre: {cityInfo.name}");

var (_, lng2, _) = getLocationCDMX();
Console.WriteLine(lng2);

static (double lat, double lng, string name) getLocationCDMX()
{
    double lat = 16.34434;
    double lng = -4.4354344;
    string name = "CDMX";
    
    return (lat, lng, name);
}