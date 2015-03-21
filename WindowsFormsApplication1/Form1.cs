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
        }

        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Envoie un message : " + textBox2.Text);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("Message from Client$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            byte[] inStream = new byte[10025];
            serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
            string returndata = System.Text.Encoding.ASCII.GetString(inStream);
            msg("Data from Server : " + returndata);
        }

        public void msg(string mesg)
        {
            this.listMessages.Items.Add(mesg);
        } 
    }
}
