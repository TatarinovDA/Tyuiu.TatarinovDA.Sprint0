// See https://aka.ms/new-console-template for more information
using Tyuiu.TatarinovDA.Sprint0.Task5.V0.Lib;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("A + B = " + DataService.Addition(1, 5));
        Console.WriteLine("A - B = " + DataService.Substraction(15, 5));
        Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));
        Console.WriteLine("A / B = " + DataService.Division(9, 3));
        Console.ReadKey();
    }
}
