using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace Client
{
   public class Client2
    {
        public static string Host = "192.168.0.16";
        public static int Port = 8585;
        public static TcpClient client = new TcpClient();
        
        public static void Connect()
        {
            Random random = new Random();
            int number;
            number = random.Next(1, 10);


            client.BeginConnect(Host, Port, new AsyncCallback(ConnectCallBack), number);

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
