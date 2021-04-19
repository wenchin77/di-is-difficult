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

            // TODO: 寫個新的 IMessageWriter 實作看看
        }
    }
}
