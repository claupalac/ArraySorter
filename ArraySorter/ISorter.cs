using System.Collections.Generic;

namespace ArraySorter
{
    public interface ISorter
    {
        void Sort(ref List<string> list, IComparator comparator);
    }
}