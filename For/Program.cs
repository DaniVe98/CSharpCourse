// See https://aka.ms/new-console-template for more information
string[] friends = new string[6]
{
    "Pancho",
    "Paco",
    "Ana",
    "Ruben",
    "Karla",
    "Luis"
};

bool run = true;
for (int i = 0; i < friends.Length && run; i++)
{
    Console.WriteLine(friends[i]);
}
