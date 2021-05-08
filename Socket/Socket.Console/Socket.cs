using System;
namespace Socket.Console
{
    public class Socket
    {
        private readonly IElectricalPlug _plug;

        // 建構子注入
        public Socket(IElectricalPlug plug)
        {
            if (plug == null)
                throw new ArgumentNullException("plug 為空值");

            this._plug = plug;
        }

        public void SendPower()
        {
            this._plug.Connect();
        }
    }
}