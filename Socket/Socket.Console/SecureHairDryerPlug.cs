namespace Socket.Console
{
    public class SecureHairDryerPlug : IElectricalPlug
    {
        public IElectricalPlug plug { get; set; }
        public string identity { get; set; }

        // 裝飾者模式, 用建構子注入要被裝飾的插頭
        public SecureHairDryerPlug(IElectricalPlug plug, string identity)
        {
            this.plug = plug;
            this.identity = identity;
        }

        public void Connect()
        {
            if (identity == "Mom")
            {
                System.Console.WriteLine("SecureHairDryerPlug: identity verified.");
                plug.Connect();
            }
        }
    }
}