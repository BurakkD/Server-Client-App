using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace WpfApp1
{
    public class Server1
    {

        public static TcpListener serverListener;
        public static int port { get; set; }
        public static bool[] clients = new bool[100];
        
        public static void SetupServer()
        {
            serverListener = new TcpListener(IPAddress.Any, 8585);
            Console.WriteLine("server kuruldu");
        }
        public static void StartServer()
        {

           
            serverListener.Start();

            serverListener.BeginAcceptTcpClient(callBack, null);
        
        }
        

        public static void callBack(IAsyncResult ar)
        {
            Lamp lamp = new Lamp();
            
           

            bool[] result = new bool[100];

            TcpClient client = serverListener.EndAcceptTcpClient(ar);
            Connect connect = new Connect(client);
            result[0] = connect.deneme();
            clients[0] = result[0];
                   

        }
        




    }
}
