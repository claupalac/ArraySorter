using System.Collections.Generic;

namespace ArraySorter
{
    public interface ISorter
    {
        void Sort(List<string> list, IComparator comparator);
    }
}