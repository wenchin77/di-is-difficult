using HelloDI.Console;

namespace HelloDI.Tests.Fakes
{
    public class TestSpyMessageWriter : IMessageWriter
    {
        public string MessageWritten { get; private set; }
        public void Write(string message)
        {
            MessageWritten += message;
        }
    }
}
