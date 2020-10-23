using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindBiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = {5, 10, 8, 2, 6, 25, 60, 10, 16, 28 };

            int biggestNr = 0;
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > biggestNr)
                {
                    biggestNr = array[i];
                    index = Array.IndexOf(array, array[i]);
                }
            }
            Console.WriteLine($"The biggest number is {biggestNr} {index}");
        }
    }
}
