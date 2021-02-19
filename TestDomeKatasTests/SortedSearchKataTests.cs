using FluentAssertions;
using NUnit.Framework;
using TestDomeKatas;

namespace TestDomeKatasTests
{
    [TestFixture]
    public class SortedSearchKataTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(4, 2)]
        [TestCase(7, 3)]
        [TestCase(9, 5)]
        public void Given_SortedArray_When_Multiple_Values_Then_Should_Get_Valid_CountNumbers(int lessThan, int expectedCount)
        {
            // arrange
            var sortedArray = new[] { 1, 3, 5, 7, 8 };

            // act
            var count1 = SortedSearchKata.CountNumbersVersionOne(sortedArray, lessThan);
            var count2 = SortedSearchKata.CountNumbersVersionTwo(sortedArray, lessThan);
            var count3 = SortedSearchKata.CountNumbersVersionThree(sortedArray, lessThan);

            // assert
            count1.Should().Be(expectedCount);
            count2.Should().Be(expectedCount);
            count3.Should().Be(expectedCount);
        }

        [TestCase(2, 0)]
        [TestCase(5, 0)]
        [TestCase(7, 1)]
        [TestCase(9, 1)]
        public void Given_SortedArray_When_Single_Value_Then_Should_Get_Valid_CountNumbers(int lessThan, int expectedCount)
        {
            // arrange
            var sortedArray = new[] { 5 };

            // act
            var count1 = SortedSearchKata.CountNumbersVersionOne(sortedArray, lessThan);
            var count2 = SortedSearchKata.CountNumbersVersionTwo(sortedArray, lessThan);
            var count3 = SortedSearchKata.CountNumbersVersionThree(sortedArray, lessThan);

            // assert
            count1.Should().Be(expectedCount);
            count2.Should().Be(expectedCount);
            count3.Should().Be(expectedCount);
        }
    }
}
