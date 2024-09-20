// See https://aka.ms/new-console-template for more information

int i = 0;

while(i < 10)
{
    Console.WriteLine("Iteracion de i " + i);
    i++;
}

int j = 0;

while(j < 100)
{
    if(j > 10)
    break;

    Console.WriteLine("Iteracion de j " + j);
    j++;

}


string[] friends = new string[6]
{
    "Pancho",
    "Paco",
    "Ana",
    "Ruben",
    "Karla",
    "Luis"
};

//Iterando con un array
int index = 0;
while (index < friends.Length)
{
    Console.WriteLine(friends[index]);
    index++;
}


bool run = false;
do
{
    show();
} while (run);


static void show()
{
    Console.WriteLine("Entro una vez y listo");
};







