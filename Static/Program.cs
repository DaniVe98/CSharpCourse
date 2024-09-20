// See https://aka.ms/new-console-template for more information

People hector = new People()
{
    Name = "hector",
    Age = 34
};

People dani = new People()
{
    Name = "dani",
    Age = 25
};



Console.WriteLine(People.Count);
Console.WriteLine(People.GetCount());

//Todos los metodos de Math son estaticos
    //Math.Min

public static class Example1
{
    public static void Some()
    {
        Console.WriteLine("algo");
    }
}

public class People
{
    public static int Count = 0;
    public string Name { get; set; }
    public int Age { get; set; }

    public People()
    {
        Count++;
    }

    public static string GetCount()
    {
        return $"Esta clase se ha utilizado {Count} veces";
    }
}