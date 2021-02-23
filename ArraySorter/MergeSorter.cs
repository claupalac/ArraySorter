using System.Collections.Generic;

namespace ArraySorter
{
    public class MergeSorter: ISorter
    {
        public void Sort(List<string> list, IComparator comparator)
        {
            MergeSort(list, comparator);
        }
        private static List<string> MergeSort(List<string> list, IComparator comparator)
        {
            List<string> left = new List<string>();
            List<string> right = new List<string>();

            if (list.Count <= 1) return list;
            int midPoint = list.Count / 2;
            for (int i = 0; i < midPoint; i++) left.Add(list[i]);
            for (int i = midPoint; i < list.Count; i++) right.Add(list[i]);
            
            left = MergeSort(left,comparator);
            right = MergeSort(right,comparator);
            
            return Merge(left, right, comparator);
        }
        
        private static List<string> Merge(List<string> left, List<string> right, IComparator comparator)
        {
            int resultLength = right.Count + left.Count;
            List<string> result = new List<string>();
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            while (indexLeft < left.Count || indexRight < right.Count)
            {
                if (indexLeft < left.Count && indexRight < right.Count)
                {
                    if (comparator.Compare(left[indexLeft], right[indexRight]) < 0)
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Count)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Count)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }

            return result;
        }
    }
    }