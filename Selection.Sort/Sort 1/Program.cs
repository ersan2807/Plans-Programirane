using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Selectionsort.Sort(number);
            Console.WriteLine(string.Join(" ",number));
        }
    }
}
