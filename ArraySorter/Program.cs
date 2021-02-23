using System;
using System.Collections.Generic;

namespace ArraySorter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ISorter sorter = new QuickSorter();

            List<string> list = new List<string>()
            {
                "f", "h", "c", "w", "b", "v", "e", "a"
            };
            
            Console.WriteLine("\nArray Before Sort:");
            PrintList(list);
            
            Console.WriteLine("\nArray After Sort: Ascendent");
            sorter.Sort(list, new ComparatorAscendent());
            PrintList(list);
            
            Console.WriteLine("\nArray After Sort: Descendent");
            sorter = new BubbleSort();
            sorter.Sort(list, new ComparatorDescendant());
            PrintList(list);
        }

        public static void PrintList(List<string> list)
        {
            foreach (var VARIABLE in list)
            {
                Console.Write($"\t"+ VARIABLE);
            }
        }
    }
}