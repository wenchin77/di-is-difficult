using Socket.Console;

namespace Socket.Tests.Fakes
{
    public class TestSpyPlug : IElectricalPlug
    {
        public int ConnectCount { get; private set; } = 0;
        public void Connect()
        {
            ConnectCount += 1;
        }
    }
}
