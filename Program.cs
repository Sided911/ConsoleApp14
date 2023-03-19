using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //нахождение минимального и максимального значения и его индекса
            int[] array = { 8, -1, 4, 16, -5, 3 };
            int min = array[0];
            int indexMin = 0;
            int max = array[0];
            int indexMax= array[0];
            for(int i=1;i<array.Length;i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indexMax = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    indexMin = i;
                }
            }
            Console.WriteLine($"max={max}\tindexMax={indexMax}");
            Console.WriteLine($"min={min}\tindexMin={indexMin}");
            Console.ReadKey();
        }
    }
}
