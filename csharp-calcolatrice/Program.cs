using csharp_calcolatrice.Classes;

namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Calculator.sumOfTwoT(2, 3));
            Console.WriteLine(Calculator.substractionOfTwoT(2, 3));
            Console.WriteLine(Calculator.multiplyTwoT(2, 3));
            Console.WriteLine(Calculator.AbsoluteValueOf(2));
            Console.WriteLine(Calculator.MinOf(2, 3));
            Console.WriteLine(Calculator.MaxOf(2, 3));
            Console.WriteLine(Calculator.PowerOf(2, 0));
            Console.WriteLine(Calculator.PowerOfAlt(0, 0));
        }
    }
}