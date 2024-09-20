
Operation mySum = Functions.Sum;
mySum = Functions.Sum;
Console.WriteLine(mySum(2, 3));

mySum = Functions.Mul;
Console.WriteLine(mySum(2, 3));

Show cw = Console.WriteLine;
cw += Functions.ConsoleShow;
//cw("Hello world");

Functions.Some("Juan", "Guevara", cw);

delegate int Operation(int a, int b);
public delegate void Show(string message);
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
}