namespace HelloDI.Console
{
    public class SecureMessageWriter : IMessageWriter
    {
        public IMessageWriter writer { get; set; }
        public string identity { get; set; }

        // 建構子
        public SecureMessageWriter(IMessageWriter writer, string identity)
        {
            this.writer = writer;
            this.identity = identity;
        }

        public void Write(string message)
        {
            if (identity == "A")
            {
                writer.Write("(Secured) " + message);
            }
        }
    }
}