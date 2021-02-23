using System;
using System.Collections.Generic;
using ArraySorter;
using Xunit;

namespace ArraySorterTests
{
    public class SorterTest : IDisposable
    {
        ISorter sorter;
        public SorterTest()
        {
            sorter = new MergeSorter();
        }
        [Fact]
        void Sort_WithAlphabetArrayOfFiveElements_ShouldSortAcendent()
        {
            List<string> aList = new List<string>()
            {
                "d", "e", "a", "c", "b"
            };
            List<string> expected = new List<string>()
            {
                "a", "b", "c", "d", "e"
            };
            
            sorter.Sort(aList,new FakeComparator());
            
            Assert.Equal(expected,aList);
            
        }
        public void Dispose()
        {
            sorter = null;
        }
    }

    public class FakeComparator : IComparator
    {
        public int Compare(string string1, string string2)
        {
            return string1.CompareTo(string2);
        }
    }
}