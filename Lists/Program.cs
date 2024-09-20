// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

List<int> numbers = new List<int>();
numbers.Add(5);
numbers.Add(6);

Console.WriteLine(numbers.Count);

List<int> numbers2 = new List<int>()
{
    1,4,5,5,6,7,7,7,7,7,90,90
};
numbers2.Add(6);
numbers2.Add(7);
numbers2.Add(8);
Console.WriteLine(numbers2.Count);

numbers2.Clear();
Console.WriteLine(numbers2.Count);

List<string> countries = new List<string>()
{
    "Colombia", "Mexico", "Chile"
};

Console.WriteLine(countries.Count);

