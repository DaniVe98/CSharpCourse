// See https://aka.ms/new-console-template for more information

Sale mySale = new Sale(100, DateTime.Now);
mySale.Date = DateTime.Now;
//Console.WriteLine(mySale.Total);
Console.WriteLine(mySale.Date);

class Sale
{
    int total;
    private DateTime date;

    public string Date
    {
        get
        {
            return date.ToLongDateString();
        }
    }

    //Camino para poner una propiedad y acceder al valor de manera pública del (int total)
    public int Total
    {
        get
        {
            return total;
        }
        set
        {
            if(value < 0)
            {
                value = 0;
                total = value;
            }
        }
    }

    public Sale(int total, DateTime date)
    {
        this.total = total;
        this.date = date;
    }
}