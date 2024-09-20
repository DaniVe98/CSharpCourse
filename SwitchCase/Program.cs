// See https://aka.ms/new-console-template for more information

int op = 5;

switch (op)
{
    case 1:
        Console.WriteLine("Seleccionaste el 1");
        break;
    case 2:
        Console.WriteLine("Seleccionaste el 2");
        break;
    case 3:
    case 4:
        Console.WriteLine("Seleccionaste el 3 o 4");
        break;
    case < 0:
    case > 100:
        Console.WriteLine("Fuera de rango");
        break;
    case > 4 and < 10:
        Console.WriteLine("Seleccionaste una opcion entre 4 y 10");
        break;
    default:
        Console.WriteLine("Invalido");
        break;
}