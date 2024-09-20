// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

List<int> numbers = new List<int>()
{
    4,4,45,9
};


Show(numbers);
numbers.Insert(0, 6);
Show(numbers);
numbers.Add(4000);
Show(numbers);
if (numbers.Contains(4000))
    Console.WriteLine("existe");
else
    Console.WriteLine("no existe");

// IndexOf
int pos = numbers.IndexOf(4000);
Console.WriteLine(pos);

// Sort
// Recordar que las Listas son mutables, es decir que son modificables dentro de su estructura:
numbers.Sort();
Show(numbers);

// Ejemplo de inmutable, como lo es "string":
string name = "Daniel";
name = name.ToUpper();
Console.WriteLine(name);

// Add Range
numbers.AddRange(new List<int>()
{
    2,4,5,6,6,7
});
Show(numbers);

var numbers2 = new List<int>()
{
    29,39,32
};

numbers.AddRange(numbers2);
Show(numbers);


static void Show(List<int> numbers)
{
    Console.WriteLine("-- Numeros --");
    foreach(var n in numbers)
    {
        Console.WriteLine(n);
    }
}