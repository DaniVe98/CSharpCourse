// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

var numbers = new List<int>()
{
    23,3,4,4,5,6,78,8
};

foreach(var number in numbers)
{
    Console.WriteLine(number);
}

var students = new List<People>()
{
    new People() {Name = "Hector", Country = "Mexico"},
    new People() {Name = "Daniel", Country = "Colombia"},
    new People() {Name = "Nicolas", Country = "Argentina"},
};

var students2 = new List<People>()
{
    new People() {Name = "Fabio", Country = "Chile"},
    new People() {Name = "Gio", Country = "PH"},
    new People() {Name = "Sandra", Country = "Holanda"},
};

Show(students);
Show(students2);
students.RemoveAt(0);

Show(students);

static void Show(List<People> students)
{
    Console.WriteLine("-- Personas --");
    foreach(var people in students)
    {
        Console.WriteLine($"Nombre: {people.Name}, País: {people.Country}");
    }
}

class People
{
    public string Name { get; set; }
    public string Country { get; set; }
}

