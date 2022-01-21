using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace Client
{
   public static class Client2
    {
        public static string Host = "192.168.0.16";
        public static int Port = 8585;
        public static TcpClient client1 = new TcpClient();
        public static NetworkStream stream;

        public static void Connect()
        {
          
            client1.BeginConnect(Host, Port, new AsyncCallback(ConnectCallBack), randonNumber());

        }
        public static void ConnectCallBack(IAsyncResult asyncResult)
        {



            client1.EndConnect(asyncResult);
            if (client1.Connected)
            {
                stream = client1.GetStream();
                Sendata();
            }
            



        }
        public static void Sendata()
        {
            
            byte[] data = Encoding.UTF8.GetBytes(randonNumber());
            stream.BeginWrite(data, 0, data.Length, new AsyncCallback(SendCallback), null);

        }
        public static void SendCallback(IAsyncResult asyncResult)
        {
            stream.EndWrite(asyncResult);
            
        }
        public static string randonNumber()
        {
            var result = String.Empty;
            Random random = new Random();

            for (int i = 0; i < 4; i++)
            {
                result += random.Next(0, 4);
            }
            return result;
        }
    }
}
