using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client
{
   public class Client1
    {
        public static string Host = "192.168.0.16";
        public static int Port = 8585;
        public static TcpClient client = new TcpClient();
        public static void Connect()
        {

            client.BeginConnect(Host, Port, new AsyncCallback(ConnectCallBack), null);
          



        }
   
        public static void ConnectCallBack(IAsyncResult asyncResult)
        {
            client.EndConnect(asyncResult);
            if (client.Connected)
            {
                Console.WriteLine("bağlanıldı");

            }
        }


    }
}
