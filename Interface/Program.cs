// See https://aka.ms/new-console-template for more information


Shark[] sharks = new Shark[]
{
    new Shark("Tiburonsin u ja ja", 56),
    new Shark("Jaws", 65)
};

IFish[] fishs = new IFish[]
{
    new Siren(100),
    new Shark("Manuel", 90)
};

ShowFish(sharks);
ShowAnimal(sharks);
ShowFish(fishs);

void ShowFish(IFish[] fishes)
{
    Console.WriteLine("- Mostramos los peces -");
    int i = 0;
    while (i < fishes.Length)
    {
        Console.WriteLine(fishes[i].Swim());
        i++;
    }
}

void ShowAnimal(IAnimal[] animales)
{
    Console.WriteLine("- Mostramos los animales -");
    int i = 0;
    while (i < animales.Length)
    {
        Console.WriteLine(animales[i].Name);
        i++;
    }
}

public class Siren : IFish
{
    public int Speed { get; set; }
    public Siren(int Speed)
    {
        this.Speed = Speed;
    }

    public string Swim()
    {
        return $"La sirena nada a {Speed} km/h";
    }
}

public class Shark : IAnimal, IFish
{
    public string Name { get; set; }
    public int Speed { get; set; }
    public Shark(string Name, int Speed)
    {
        this.Name = Name;
        this.Speed = Speed;
    }
    public string Swim()
    {
        return $"{Name} Nada {Speed} km/h";
    }
}

public interface IAnimal
{
    public string Name { get; set; }
}

public interface IFish
{
    public int Speed { get; set; }
    public string Swim();
}
