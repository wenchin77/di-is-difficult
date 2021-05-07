namespace HelloDI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // 原本只要這樣一行
            System.Console.WriteLine("Hello World!");

            // 用 DI 的方法
            IMessageWriter writer = new ConsoleMessageWriter();
            var salutation = new Salutation(writer);
            salutation.Say("Hello DI!");

            // 用裝飾者模式寫個新的 IMessageWriter 實作看看
            IMessageWriter secureWriter = new SecureMessageWriter(writer, "A");
            var salutation1 = new Salutation(secureWriter);
            salutation1.Say("Hello DI!!!!!");
        }
    }
}
