using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_1
{
    internal class Selectionsort
    {
        public static void Swap<T>(T[] elements,int first, int second)
        {
            T temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }
        public static void Sort<T>(T[] arr) where T : IComparable
        {
            for(int index = 0; index < arr.Length; index++)
            {
                int min = index;
                for(int curr= index+1;curr< arr.Length; curr++)
                {
                    if (IsLess(arr[curr], arr[min]))
                    {
                        min = curr;
                    }
                }
            }
        }
        static bool IsLess(IComparable first,IComparable second)
        {
            return first.CompareTo(second) < 0;
        }
    }
}
