
//Delegado con un solo parametro (para que funcione, comenta el codigo abajo con 2 parametros):

using System.Timers;

Operation mySum = Functions.Sum;
mySum = Functions.Sum;
Console.WriteLine(mySum(2, 3));



mySum = Functions.Mul;
Console.WriteLine(mySum(2, 3));



Show cw = Console.WriteLine;
cw += Functions.ConsoleShow;
//cw("Hello world");



//Functions.Some("Juan", "Guevara", cw);



#region Action
string hi = "Hola";
Action<string> showMessage = Console.WriteLine;
Action<string, string> showMessage2 = (a, b) =>
{
    Console.WriteLine($"{hi} {a} {b}");
};
Action<string, string, string> showMessage3 = (a, b, c) => Console.WriteLine($"Que se dice {a} {b} el {c} crack");

//showMessage2("Hector", "De Leon");
//showMessage3("Hector", "De Leon", "Dev");
//Functions.SomeAction("Jaime", "Ramirez", (a) => Console.WriteLine("soy una expresion " + a));


//showMessage("hola pepsicola");
//Functions.SomeAction("Jaime", "Ramirez", showMessage);
#endregion

#region Func
Func<int> numberRandom = () => new Random().Next(0, 100);
//El ultimo elemento es siempre el que vamos a retornar, los otros son para recibir
//Si tenemos mas de 1 linea no es necesario colocar "return", pero si son mas de 2 lineas en adelante toca colocar { } y el return para que funcione.
//IMPORTANTE: Action es para no retornar, Func es para retornar algo si o si siempre
Func<int, int> numberRandomLimit = (limit) => new Random().Next(0, limit);

//Console.WriteLine(numberRandom());
//Console.WriteLine(numberRandomLimit(10000));
#endregion

#region Predicate
//Solo recibe un parametro booleano
Predicate<string> hasSpaceorA = (word) => word.Contains(" ") || word.ToUpper().Contains("A");
//Console.WriteLine(hasSpaceorA("beer "));
//Console.WriteLine(hasSpaceorA("patito"));

var words = new List<string>()
{
    "beer",
    "patito",
    "sandia",
    "hola mundo",
    "c#"
};

//Para hacerlo de manera negativa es asi con una expresion lambda
var words2 = words.FindAll((w)=>!hasSpaceorA(w));
foreach(var w in words2)
{
    Console.WriteLine(w);
}
#endregion


//En vez de ponernos a crear varios delegados, podemos crear delegados con Action que viene por defecto en C#
#region Delegados
delegate int Operation(int a, int b);
public delegate void Show(string message);
public delegate void Show2(string message, string message2);
public delegate void Show3(string message, string message2, string message3);
#endregion



public class Functions
{
    public static int Sum(int x, int y) => x + y;
    public static int Mul(int num1, int num2) => num1 * num2;
    public static void ConsoleShow(string m) => Console.WriteLine(m.ToUpper());
    public static void Some(string name, string lastName, Show fn)
    {
        Console.WriteLine("Hago algo al inicio");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo al final");
    }



    public static void SomeAction(string name, string lastName, Action<string> fn)
    {
        Console.WriteLine("El secreto es");
        fn($"Mi amor es {name} {lastName}");
        Console.WriteLine("Finalmente confesado");
    }
}
