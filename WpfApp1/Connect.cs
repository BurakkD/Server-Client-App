using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace WpfApp1
{
    public  class Connect
    {
        public static NetworkStream network;
        public static byte[] buffer = new byte[4096];
        public static string[] gelen = new string[100];
        Lamp lamp = new Lamp();

        TcpClient connect;
        public  Connect(TcpClient _connect)
        {
            connect = _connect;
        }


        public bool deneme()
        {
            if (connect.Connected == true)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public void GetData()
        {
            network = connect.GetStream();
            network.BeginRead(buffer, 0, 4096, new AsyncCallback(ReceiveCallback), null);
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            int gelenveri = network.EndRead(ar);
            byte[] _data = new byte[gelenveri];
            Array.Copy(buffer, _data, gelenveri);
            gelen[0] = Encoding.UTF8.GetString(_data);
            connect.Close();
            Server1.serverListener.Stop();
        }
    }
}

