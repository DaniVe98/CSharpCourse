// See https://aka.ms/new-console-template for more information

using BaseDeDatos2;
using System.Data.SqlClient;

try
{
    BeerDB beerDB = new BeerDB(".", "CsharpDB", "sa", "Inchcape@2023<");
    bool again = true;
    int op = 0;

    do
    {
        ShowMenu();
        Console.WriteLine("Elige una opción: ");
        op = int.Parse(Console.ReadLine());

        switch (op)
        {

            case 1:
                Show(beerDB);
                break;
            case 2:
                Add(beerDB);
                break;
            case 5:
                again = false;
                break;
        }
    }
    while (again);
}
catch (SqlException ex)
{
    Console.WriteLine("No pudimos conectarnos. " + ex.Message);
}

static void ShowMenu()
{
    Console.WriteLine("\n-------Menu--------");
    Console.WriteLine("1.- Mostrar");
    Console.WriteLine("2.- Agregar");
    Console.WriteLine("3.- Editar");
    Console.WriteLine("4.- Eliminar");
    Console.WriteLine("5.- Salir");
}

static void Show(BeerDB beerDB)
{
    Console.Clear();
    Console.WriteLine("Cervezas de la base de datos");
    List<Beer> beers = beerDB.GetAll();

    foreach (var beer in beers)
    {
        Console.WriteLine(beer.Name);
    }
}

static void Add(BeerDB beerDB)
{
    Console.Clear();
    Console.WriteLine("Agregar nueva cerveza");
    Console.WriteLine("Escribe el nombre:");
    string name = Console.ReadLine();
    Console.WriteLine("Escribe el id de la marca");
    int brandId = int.Parse(Console.ReadLine());
    Beer beer = new Beer(name, brandId);
    beerDB.Add(beer);
}


