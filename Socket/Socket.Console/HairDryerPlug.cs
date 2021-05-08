namespace Socket.Console
{
    public class HairDryerPlug : IElectricalPlug
    {
        public void Connect()
        {
            System.Console.WriteLine("HairDryerPlug connected!\n");
        }
    }
}