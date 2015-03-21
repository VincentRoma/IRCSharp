using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;



namespace WindowsFormsApplication1
{
    public partial class IRCSharp : Form
    {
        private IPAddress ipAd;

        public IPAddress IpAd
        {
            get { return ipAd; }
            set { ipAd = value; }
        }

        private TcpClient clientSocket;

        public TcpClient ClientSocket
        {
            get { return clientSocket; }
            set { clientSocket = value; }
        }

        private StreamReader streamReader;

        public StreamReader StreamReader
        {
            get { return streamReader; }
            set { streamReader = value; }
        }

        private StreamWriter streamWriter;

        public StreamWriter StreamWriter
        {
            get { return streamWriter; }
            set { streamWriter = value; }
        }

        private NetworkStream networkStream;

        public NetworkStream NetworkStream
        {
            get { return networkStream; }
            set { networkStream = value; }
        }

        public IRCSharp()
        {
            InitializeComponent();
        }

        private void labelClientHote_Click(object sender, EventArgs e)
        {

        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            this.ipAd = IPAddress.Parse(textBoxServeurHote.Text);
            this.clientSocket = new TcpClient();
            this.clientSocket.Connect(ipAd, int.Parse(textBoxServeurPort.Text));
            this.NetworkStream = clientSocket.GetStream();
            this.streamReader = new StreamReader(networkStream);
            this.streamWriter = new StreamWriter(networkStream);

        }

        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Envoie un message : " + textBox2.Text);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {


         //   byte[] b = new byte[100];
           // String str = textBox2.Text;
            //byte[] converted = System.Text.Encoding.UTF8.GetBytes(str);
            //networkStream.Write(converted, 0, 1);


            Console.WriteLine("Envoie un message : " + textBox2.Text);
            this.streamWriter.WriteLine(textBox2.Text);
            this.streamWriter.Flush();
        }
    }
}
