using BenchmarkDotNet.Running;

namespace TestDomeKatasBenchs
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var benchmarks = new[]
            {
                typeof(SortedSearchBench),
                typeof(TrainCompositionBench),
                typeof(ParagraphKataBench),
            };

            var switcher = new BenchmarkSwitcher(benchmarks);
            switcher.Run(args);
        }
    }
}
