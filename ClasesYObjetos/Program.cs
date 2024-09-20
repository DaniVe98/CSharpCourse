// See https://aka.ms/new-console-template for more information

Sale sale1 = new Sale(100, DateTime.Now);
Sale sale2 = new Sale(200, DateTime.Now);
Console.WriteLine(sale1.GetInfo());
sale2.GetInfo();

class Sale
{
    int total;
    DateTime date;

    //Este es el constructor
    public Sale(int total, DateTime date)
    {
        this.total = total;
        this.date = date;
    }

    public string GetInfo()
    {
        return total + " " + date.ToLongDateString();
    }
    public void Show()
    {
        Console.WriteLine("Hola soy una venta");
    }
}