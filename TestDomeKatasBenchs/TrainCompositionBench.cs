using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using TestDomeKatas;

namespace TestDomeKatasBenchs
{
    [Config(typeof(BenchConfig))]
    public class TrainCompositionBench
    {
        private int _value;
        private TrainCompositionKata _kata;

        [Params(100, 1000, 10000)]
        public int Size { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            var array = Enumerable.Range(0, Size)
                .Select(_ => random.Next(0, 10 * Size))
                .ToArray();
            _value = random.Next(0, Size);
            _kata = new TrainCompositionKata(array);
        }

        [Benchmark]
        public void AttachWagonFromLeft()
        {
            _kata.AttachWagonFromLeft(_value);
        }

        [Benchmark]
        public void AttachWagonFromRight()
        {
            _kata.AttachWagonFromRight(_value);
        }

        [Benchmark]
        public int DetachWagonFromLeft() => _kata.DetachWagonFromLeft();

        [Benchmark]
        public int DetachWagonFromRight() => _kata.DetachWagonFromRight();
    }
}
