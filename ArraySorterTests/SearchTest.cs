using System.Collections.Generic;
using ArraySorter.Search;
using Xunit;

namespace ArraySorterTests
{
    public class SearchTest
    {
        [Fact]
        void Search_WithListContainingTheSearchedValue_ShouldReturnSearchedValue()
        {
            ISearcher searcher = new BinarySearcher();
            var searchedValue = "Claudio";
            List<string> aList = new List<string>()
            {
                "Bustillos", "Claudio", "Iniesta", "Palacios", "Vanessa"
            };

            var actual = searcher.GetItemSearched(aList, searchedValue);
            
            
            Assert.Equal(actual,searchedValue);
        }
        
        [Fact]
        void Search_WithListNotContainingTheSearchedValue_ShouldReturnNull()
        {
            ISearcher searcher = new BinarySearcher();
            var searchedValue = "Claudio2";
            List<string> aList = new List<string>()
            {
                "Bustillos", "Claudio", "Iniesta", "Palacios", "Vanessa"
            };

            var actual = searcher.GetItemSearched(aList, searchedValue);
            
            
            Assert.Null(actual);
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