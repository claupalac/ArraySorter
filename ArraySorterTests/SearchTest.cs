using System.Collections.Generic;
using ArraySorter.Search;
using Xunit;

namespace ArraySorterTests
{
    public class SearchTest
    {
        [Fact]
        void Search_WithBinarySearch_ShouldReturnSameValue()
        {
            ISearcher searcher = new BinarySearcher();
            var expected = "Claudio";
            List<string> aList = new List<string>()
            {
                "Bustillos", "Claudio", "Iniesta", "Palacios", "Vanessa"
            };

            var actual = searcher.GetItemSearched(aList, expected);
            
            Assert.Equal(actual,expected);
        }
        
        [Fact]
        void Search_WithJumpSearch_ShouldReturnSameValue()
        {
            ISearcher searcher = new JumpSearch();
            var expected = "Claudio";
            List<string> aList = new List<string>()
            {
                "Bustillos", "Claudio", "Iniesta", "Palacios", "Vanessa"
            };

            var actual = searcher.GetItemSearched(aList, expected);
            
            Assert.Equal(expected,actual);
        }
    }
}