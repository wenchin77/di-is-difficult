using FluentAssertions;
using HelloDI.Console;
using HelloDI.Tests.Fakes;
using Xunit;

namespace HelloDI.Tests
{
    public class SalutationTests
    {
        [Fact]
        public void SayWillWriteCorrectMessageToMessageWriter()
        {
            // Arrange
            var writer = new TestSpyMessageWriter();

            var systemUnderTest = new Salutation(writer);

            // Act
            var message = "Test DI!";
            systemUnderTest.Say(message);

            // Assert
            writer.MessageWritten.Should().Be(message);
        }
    }
}
