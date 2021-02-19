using FluentAssertions;
using NUnit.Framework;
using TestDomeKatas;

namespace TestDomeKatasTests
{
    [TestFixture]
    public class TrainCompositionKataTests
    {
        [Test]
        public void When_Attach_And_Detach_From_Left_Then_Should_Get_Valid_Value()
        {
            // arrange
            var kata = new TrainCompositionKata();

            // act
            kata.AttachWagonFromLeft(7);
            kata.AttachWagonFromLeft(13);
            var value1 = kata.DetachWagonFromLeft();
            var value2 = kata.DetachWagonFromLeft();

            // assert
            value1.Should().Be(13);
            value2.Should().Be(7);
        }

        [Test]
        public void When_Attach_And_Detach_From_Right_Then_Should_Get_Valid_Value()
        {
            // arrange
            var kata = new TrainCompositionKata();

            // act
            kata.AttachWagonFromRight(7);
            kata.AttachWagonFromRight(13);
            var value1 = kata.DetachWagonFromRight();
            var value2 = kata.DetachWagonFromRight();

            // assert
            value1.Should().Be(13);
            value2.Should().Be(7);
        }
    }
}
