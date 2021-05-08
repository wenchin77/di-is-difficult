namespace Socket.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("使用吹風機插頭");
            IElectricalPlug hairDryerPlug = new HairDryerPlug();
            var socket = new Socket(hairDryerPlug);
            socket.SendPower();

            // 用裝飾者模式實作另一個 IElectricalPlug (插頭介面) 看看
            System.Console.WriteLine("使用經身分驗證的安全吹風機插頭");
            IElectricalPlug secureHairDryerPlug = new SecureHairDryerPlug(hairDryerPlug, "Mom");
            var socketDecorated = new Socket(secureHairDryerPlug);
            socketDecorated.SendPower();
        }
    }
}
