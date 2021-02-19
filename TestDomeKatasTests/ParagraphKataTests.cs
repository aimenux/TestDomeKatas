using FluentAssertions;
using NUnit.Framework;
using TestDomeKatas;

namespace TestDomeKatasTests
{
    [TestFixture]
    public class ParagraphKataTests
    {
        [TestCase(@"Please quote your policy number: 542-75-4196.",@"Please quote your policy number: 542/4196/75.")]
        [TestCase(@"Please quote your policy number: 112-39-8552.",@"Please quote your policy number: 112/8552/39.")]
        public void Should_Get_Valid_Changed_Paragraph(string paragraph, string expectedParagraph)
        {
            // arrange
            // act
            var changedParagraph = ParagraphKata.ChangeFormat(paragraph);

            // assert
            changedParagraph.Should().Be(expectedParagraph);
        }
    }
}
