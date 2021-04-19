using FluentAssertions;
using HelloDI.Console;
using Xunit;

namespace HelloDI.Tests
{
    public class SalutationTests
    {
        [Fact]
        public void SayWillWriteCorrectMessageToMessageWriter()
        {
            // Arrange
            var writer = new TestMessageWriter();

            var systemUnderTest = new Salutation(writer);

            // Act
            var message = "Test DI!";
            systemUnderTest.Say(message);

            // Assert
            writer.MessageCount.Should().Be(1);
            writer.MessageWritten.Should().Be(message);
        }
    }
}
