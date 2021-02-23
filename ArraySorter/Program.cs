using System;
using System.Collections.Generic;

namespace ArraySorter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ISorter sorter = new MergeSorter();

            List<string> list = new List<string>()
            {
                "f", "h", "c", "g", "b", "d", "e", "a"
            };
            
            Console.WriteLine("\nArray Before Sort:");
            PrintList(list);
            
            Console.WriteLine("\nArray After Sort: Ascendant");
            sorter.Sort(ref list, new ComparatorAscendant());
            PrintList(list);
            
            Console.WriteLine("\nArray After Sort: Descendent");
            sorter.Sort(ref list, new ComparatorDescendant());
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