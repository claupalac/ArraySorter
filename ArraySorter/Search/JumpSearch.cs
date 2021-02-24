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
            int step = (int)Math.Floor(Math.Sqrt(n));
            int before = 0; 
            while (list[Math.Min(step, n)-1].CompareTo(wanted) < 0) 
            { 
                before = step; 
                step += (int)Math.Floor(Math.Sqrt(n)); 
                if (before >= n) 
                    return null; 
            }
            while (list[before].CompareTo(wanted) < 0) 
            { 
                before++;
                if (before == Math.Min(step, n)) 
                    return null; 
            } 
            
            if (list[before] == wanted) 
                return list[before]; 
  
            return null; 
        } 
        
    }
}