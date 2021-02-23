using System.Collections.Generic;

namespace ArraySorter.Search
{
    public interface ISearcher
    {
        string GetItemSearched(List<string> list, string wanted);
    }
}