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
            //нахождение максимального значения  и его индекс
            int[] array = { 8, -1, 4, 16, -5, 3 };
            int indexMax = 0;
            int max = array[0];
            for (int i=1;i<array.Length;i++)
            {
                if (array[i]>max)
                {
                    max = array[i];
                    indexMax = i;
                }
            }
            Console.WriteLine($"max={max}\tindexMax={indexMax}");
            Console.ReadKey();
        }
    }
}
