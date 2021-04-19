using HelloDI.Console;

namespace HelloDI.Tests
{
    public class TestMessageWriter : IMessageWriter
    {
        public int MessageCount { get; private set; }
        public string MessageWritten { get; private set; }
        public void Write(string message)
        {
            MessageWritten = message;
            MessageCount++;
        }
    }
}
