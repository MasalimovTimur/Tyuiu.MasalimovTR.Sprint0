using Tyuiu.MasalimovTR.Sprint0.Task5.V0.Lib;
namespace Tyuiu.MasalimovTR.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B =" + DataServise.Addition(1, 5));
            Console.WriteLine("A - B =" + DataServise.Subtraction(15, 5));
            Console.WriteLine("A * B =" + DataServise.Multiolication(10, 10));
            Console.WriteLine("A / B =" + DataServise.Division(9, 3));

            Console.ReadKey();
        }
    }
}
