namespace ArraySorter
{
    public class ComparatorDescendant : IComparator
    {
        public int Compare(string string1, string string2)
        {
            return string2.CompareTo(string1);
        }
    }
}