using System;
using System.Collections.Generic;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>() {9, 2, 4, 5, 3, 1, 8, 6, 7};
            for (int i = 0; i < array.Count; i++)
            {
                int min = i;
                for (int j = i; j < array.Count; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                int temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }

            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}