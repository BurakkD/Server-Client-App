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

        Lamp lamp = new Lamp();
        
        public  bool clients(TcpClient _client)
        {
            if (_client == null)
            {
                return false;
            }

            else
            {
                if (lamp.lampstate == false)
                {
                    lamp.lampstate = true;
                }
                if (lamp.lampstate == true)
                {
                    lamp.lampstate = false;
                }
            }
            return true;
        }

        }
      
   

       

    }
}
