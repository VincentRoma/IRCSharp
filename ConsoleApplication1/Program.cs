using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        private List<TcpClient> clients;

        public List<TcpClient> Clients
        {
            get { return clients; }
            set { clients = value; }
        }

        static void Main(string[] args)
        {
            //Socket mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //mySocket.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.AcceptConnection, true);
            IPAddress ipAd = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ipAd,5000);
            listener.Start();
            Console.WriteLine("The server is running at port 5000...");
            Console.WriteLine("The local End point is  :" + listener.LocalEndpoint);
            Console.WriteLine("Waiting for a connection.....");


          
                TcpClient clientSocket = listener.AcceptTcpClient();
                
                Console.WriteLine("Connection accepted from " + clientSocket.ToString());

            
            //int k=soc.Receive(b);
            NetworkStream networkStream = clientSocket.GetStream();
            StreamReader streamReader = new StreamReader(networkStream);
            StreamWriter streamWriter = new StreamWriter(networkStream);
            streamWriter.AutoFlush = true;
//byte[] b = new byte[100];

            
            while (true)
            {
                Console.WriteLine("Message : "+streamReader.ReadLine());
             //   networkStream.Read(b, 0, 1);
             //   string line = Encoding.UTF8.GetString(b);
             //   Console.WriteLine(line);

            }
            listener.Stop();
            //Stream s = new NetworkStream(soc);
        }
    }
}
