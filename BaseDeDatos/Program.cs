// See https://aka.ms/new-console-template for more information

using BaseDeDatos;
using System.Data.SqlClient;

try
{
    DB db = new DB(".", "CsharpDB", "sa", "Inchcape@2023<");
    db.Connect();
    Console.WriteLine("Si se pudo conectar");
    db.Close();
}
catch (SqlException ex)
{
    Console.WriteLine("No pudimos conectarnos. " + ex.Message);
}