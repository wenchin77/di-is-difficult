using FluentAssertions;
using Socket.Console;
using Socket.Tests.Fakes;
using Xunit;

namespace Socket.Tests
{
    public class SalutationTests
    {
        [Fact]
        public void SayWillWriteCorrectMessageToMessageWriter()
        {
            // Arrange
            var plug = new TestSpyPlug();

            var systemUnderTest = new Socket.Console.Socket(plug);

            // Act
            systemUnderTest.SendPower();

            // Assert
            plug.ConnectCount.Should().Be(1);
        }
    }
}
