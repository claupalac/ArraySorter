using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace ArraySorter
{
    public class QuickSorter : ISorter
    {
        public void Sort(List<string> list, IComparator comparator)
        {
            QuickSort(list,0,list.Count-1,comparator);
        }

        private void QuickSort(List<string> list, int startingIndex, int endingIndex, IComparator comparator)
        {
            var central = (startingIndex + endingIndex) / 2;
            var pivote = list[central];
            var i = startingIndex;
            var j = endingIndex;
            do
            {
                while (comparator.Compare(list[i],pivote)<0) i++;
                while (comparator.Compare(list[j],pivote)>0) j--;
                if (i <= j)
                {
                    string temp;
                    temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (startingIndex < j)
            {
                QuickSort(list, startingIndex, j,comparator);
            }
            if (i < endingIndex)
            {
                QuickSort(list, i, endingIndex,comparator);
            }
            
        }
        
    }
}