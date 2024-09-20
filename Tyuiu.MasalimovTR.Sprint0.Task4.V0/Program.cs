using Tyuiu.MasalimovTR.Sprint0.Task4.V0.Lib;
namespace Tyuiu.MasalimovTR.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataServise.Addition(1, 5));
            Console.WriteLine(DataServise.Subtraction(15, 5));
            Console.WriteLine(DataServise.Multiolication(10, 10));
            Console.WriteLine(DataServise.Division(5, 5));

            Console.ReadKey();
        }
    }
}
