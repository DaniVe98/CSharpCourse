// See https://aka.ms/new-console-template for more information

bool areYouHyngry = true;
bool youHaveMoney = true;

if (areYouHyngry && youHaveMoney && IsOpenRestaurant("Lonches pepe", 17))
{
    Console.WriteLine("Come");
} else
{
    Console.WriteLine("Pues no comas");
}

static bool IsOpenRestaurant(string name, int hour = 0)
{
    if(name == "Lonches pepe" && hour > 8 && hour < 23)
    {
        return true;
    } 
    else if(name == "Restaurante 24 horas")
    {
        return true;
    }
    else
    {
        return false;
    }
}