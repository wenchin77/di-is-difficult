using System;
namespace HelloDI.Console
{
    public class Salutation
    {
        private readonly IMessageWriter _writer;

        // 建構子注入
        public Salutation(IMessageWriter writer)
        {
            if (writer == null)
                throw new ArgumentNullException("writer 為空值");

            this._writer = writer;
        }

        public void Say(string message)
        {
            this._writer.Write(message);
        }
    }
}