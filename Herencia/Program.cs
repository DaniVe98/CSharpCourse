// See https://aka.ms/new-console-template for more information

Doctor doctor1 = new Doctor("Daniel", 25, "Frontend");
Console.WriteLine(doctor1.GetInfo());
Console.WriteLine(doctor1.GetData());

Dev dev1 = new Dev("Hector", 10, "JS");
Console.WriteLine(dev1.GetInfo());
Console.WriteLine(dev1.GetData());

class People
{
    private string _name;
    private int _age;
    public People(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public string GetInfo()
    {
        return _name + " " + _age;
    }
}

class Doctor : People
{
    private string _speciality;
    public Doctor(string name, int age, string speciality) : base(name, age)
    {
        _speciality = speciality;
    }

    public string GetData()
    {
        return GetInfo() + " " + _speciality;
    }
}


class Dev : People
{
    private string _language;
    public Dev(string name, int age, string language) : base(name, age)
    {
        _language = language;
    }

    public string GetData()
    {
        return GetInfo() + " " + _language;
    }
}