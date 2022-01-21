using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            Server1.SetupServer();
            Server1.StartServer();
            
           


        }
     


        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {


        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {


            var resultt = Connect.gelen[0];

            

            var result = Server1.clients[0];
            if (result == true)
            {

                btn.Background = Brushes.Yellow;


            }
            else
            {

            }




        }

      


        public void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


            






            //var result = Server1.clients[0];
            
            //if (result == true)
            //{
            //    text.Text = "çalıştı";
            //}
            //else
            //{
            //    text.Text = "çalışmadı";
            //}



        }

        
    }
}

