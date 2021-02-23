using System.Collections.Generic;

namespace ArraySorter
{
    public class BubbleSort : ISorter
    {
        public void Sort(ref List<string> list, IComparator comparator)
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