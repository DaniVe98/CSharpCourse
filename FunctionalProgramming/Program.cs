
Operation mySum = Functions.Sum;
mySum = Functions.Sum;
Console.WriteLine(mySum(2,3));

mySum = Functions.Mul;
Console.WriteLine(mySum(2,3));

Show show = Functions.ConsoleShow;
show("Hello world");

delegate int Operation(int a, int b);
delegate void Show(string message);
public class Functions
{
    public static int Sum(int x, int y) => x + y;
    public static int Mul(int num1, int num2) => num1 * num2;
    public static void ConsoleShow(string m) => Console.WriteLine(m);
}