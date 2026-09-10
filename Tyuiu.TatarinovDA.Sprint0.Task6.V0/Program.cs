using Tyuiu.TatarinovDA.Sprint0.Task6.V0.Lib;
// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main (string[] args)
    {
        int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine ("Сумма элементов массива = " + DataService.AdditionArray(numsArray));
        Console.WriteLine ("Разность элементов массива = " + DataService.SubstractionArray(numsArray));
        Console.WriteLine ("Произведение элементов массива = " + DataService.MultiplicationArray(numsArray));
        Console.ReadKey();
    }
}
