using System;
using System.Collections.Generic;

namespace ArraySorter.Search
{
    public class BinarySearcher : ISearcher
    {
        public string GetItemSearched(List<string> list, string wanted)
        {
            return BinarySearch(list, 0, list.Count, wanted);
        }
        private string BinarySearch(List<string> list, int startingIndex, int endingIndex, string wanted)
        {
            
            if (endingIndex >= startingIndex) { 
                int middleIndex = startingIndex + (endingIndex - startingIndex) / 2; 
                
                if (list[middleIndex] == wanted) 
                    return list[middleIndex]; 
                
                if (String.Compare(list[middleIndex], wanted, StringComparison.Ordinal) > 1) 
                    return BinarySearch(list, startingIndex, middleIndex - 1, wanted); 
                
                return BinarySearch(list, middleIndex + 1, endingIndex, wanted); 
            }
            return null; 
        }
    }
}