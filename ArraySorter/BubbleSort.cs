using System.Collections.Generic;

namespace ArraySorter
{
    public class BubbleSort : ISorter
    {
        private void SwapValuesOfIndex(int index1, int index2)
        {
            
        }
        public void Sort(List<string> list, IComparator comparator)
        {
            int listLenght = list.Count;
            for (int i = 0; i < listLenght - 1; i++)
            {
                for (int j = 0; j < listLenght - i - 1; j++)
                {
                    if (comparator.Compare(list[j],list[j+1]) > 0)
                    {
                        string aux = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = aux;   
                    }
                }
            }
        }
    }
}