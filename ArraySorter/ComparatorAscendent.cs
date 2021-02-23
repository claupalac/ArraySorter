namespace ArraySorter
{
    public class ComparatorAscendent : IComparator
    {
        public int Compare(string string1, string string2)
        {
            return string1.CompareTo(string2);
        }
    }
}