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
using System.Threading;



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

        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;
        

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
            readData = "Conected to Chat Server ...";
            msg();
            this.clientSocket.Connect(ipAd, int.Parse(textBoxServeurPort.Text));
            serverStream = clientSocket.GetStream();

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBoxName.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            Thread ctThread = new Thread(getMessage);
            ctThread.Start();
        }

        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Envoie un message : " + textBox2.Text);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBox2.Text + "$");
            //byte[] outStream = Encoding.ASCII.GetBytes("PCK|SCAN|5025066840471");

            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

        private void getMessage()
        {
            while (true)
            {
                serverStream = clientSocket.GetStream();
                int buffSize = 0;
                byte[] inStream = new byte[10025];
                buffSize = 10025;

                serverStream.Read(inStream, 0, buffSize);
                string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                readData = "" + returndata;
                msg();
            }
        }

        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
                listMessages.Items.Add(" >> " + readData);
        }

    }
}
