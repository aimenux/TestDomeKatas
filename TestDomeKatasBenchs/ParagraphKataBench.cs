using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using TestDomeKatas;

namespace TestDomeKatasBenchs
{
    [Config(typeof(BenchConfig))]
    public class ParagraphKataBench
    {
        private string _paragraph;

        [Params(100, 1000, 10000)]
        public int Size { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            _paragraph = RandomString(Size);
        }

        [Benchmark]
        public string ChangeFormat()
        {
            return ParagraphKata.ChangeFormat(_paragraph);
        }

        private static string RandomString(int length)
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var prefix = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            var xxx = random.Next(100, 999);
            var yy = random.Next(10, 99);
            var zzzz = random.Next(1000, 9999);
            var suffix = $"{xxx}-{yy}-{zzzz}";
            return $"{prefix} {suffix}";
        }
    }
}
