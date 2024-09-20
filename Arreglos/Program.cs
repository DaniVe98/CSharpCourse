// See https://aka.ms/new-console-template for more information

string[] friends = new string[8]
{
    "Pancho",
    "Paco",
    "Ana",
    "Ruben",
    "Carla",
    "Luis",
    null,
    null
};

friends[0] = "Hector";

Console.WriteLine(friends[0]);
Console.WriteLine(friends[1]);
Console.WriteLine(friends[2]);
Console.WriteLine(friends[3]);
Console.WriteLine(friends[4]);
Console.WriteLine(friends[5]);
Console.WriteLine(friends[6]);

friends[7] = "Carlos";
Console.WriteLine(friends[7]);
