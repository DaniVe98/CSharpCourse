// See https://aka.ms/new-console-template for more information

using System.IO;


try
{
    string content = File.ReadAllText(@"C:\Users\daniel.vega\OneDrive - Inchcape\Escritorio\pato.txt");
    Console.WriteLine(content);

    //No existe el file llamado pato2.txt:
    //string content2 = File.ReadAllText(@"C:\Users\daniel.vega\OneDrive - Inchcape\Escritorio\pato2.txt");
    //Console.WriteLine(content2);
    throw new Exception("Ocurrio algo inesperado");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("El archivo no existe lastima");
}
catch (Exception ex2)
{
    Console.WriteLine(ex2.Message);
}
// Pase lo que pase "finally" siempre se va a ejecutar, sin importar si cayo o no en un catch, es decir haya o no una excepcion:
finally 
{
    Console.WriteLine("Aqui me he ejecutado, pase lo que pase");
}

Console.WriteLine("Aqui se sigue ejecutando el código");
