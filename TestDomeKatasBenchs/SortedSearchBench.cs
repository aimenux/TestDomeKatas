using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using TestDomeKatas;

namespace TestDomeKatasBenchs
{
    [Config(typeof(BenchConfig))]
    public class SortedSearchBench
    {
        private int _lessThan;
        private int[] _sortedArray;

        [Params(100, 1000, 10000)]
        public int Size { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            _lessThan = random.Next(0, Size);
            _sortedArray = Enumerable.Range(0, Size)
                .Select(_ => random.Next(0, 10 * Size))
                .ToArray();
            Array.Sort(_sortedArray);
        }

        [Benchmark]
        public int CountNumbersVersionOne()
        {
            return SortedSearchKata.CountNumbersVersionOne(_sortedArray, _lessThan);
        }

        [Benchmark]
        public int CountNumbersVersionTwo()
        {
            return SortedSearchKata.CountNumbersVersionTwo(_sortedArray, _lessThan);
        }

        [Benchmark]
        public int CountNumbersVersionThree()
        {
            return SortedSearchKata.CountNumbersVersionThree(_sortedArray, _lessThan);
        }
    }
}
