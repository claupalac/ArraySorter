using System;
using System.Collections.Generic;

namespace ArraySorter.Search
{
    
    public class JumpSearch: ISearcher
    {
        public string GetItemSearched(List<string> list, string wanted)
        {
            return Search(list, 0, list.Count, wanted);
        }
        
        private string Search(List<string> list, int startingIndex, int endingIndex, string wanted)
        { 
            int n = list.Count; 
  
            // Finding block size to be jumped 
            int step = (int)Math.Floor(Math.Sqrt(n)); 
  
            // Finding the block where element is 
            // present (if it is present) 
            int prev = 0; 
            while (list[Math.Min(step, n)-1].CompareTo(wanted) < 0) 
            { 
                prev = step; 
                step += (int)Math.Floor(Math.Sqrt(n)); 
                if (prev >= n) 
                    return null; 
            } 
  
            // Doing a linear search for x in block 
            // beginning with prev. 
            while (list[prev].CompareTo(wanted) < 0) 
            { 
                prev++; 
  
                // If we reached next block or end of 
                // array, element is not present. 
                if (prev == Math.Min(step, n)) 
                    return null; 
            } 
  
            // If element is found 
            if (list[prev] == wanted) 
                return list[prev]; 
  
            return null; 
        } 
        
    }
}