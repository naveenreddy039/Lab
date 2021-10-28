using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator objCalculator = new Calculator();
            Console.WriteLine("total values"+objCalculator.isSum(30,20));
            Console.ReadKey();
        }
    }
}
