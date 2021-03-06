using System;
using System.Collections.Generic;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            Program.ToPrint<int>(intArray);
            Program.ToPrint<double>(doubleArray);
            Program.ToPrint<char>(charArray);

        }
        public static void ToPrint<T>(T[] inputArray)
        {
            foreach(var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("--------------------------");
        }
    }
}
