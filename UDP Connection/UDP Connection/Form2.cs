using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace UDP_Connection
{
    public partial class Form2 : Form
    {
        UdpClient client;
        IPEndPoint endPoint;
        string msg;
        string neWmsg;
        byte[] buffer;
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int clientPort = int.Parse(txtClientPort.Text);
            string hostname = txtHostName.Text;
            int servierPort = int.Parse(txtServierPort.Text);

            client = new UdpClient(clientPort);

            msg = clientPort + "." + hostname + '.' + txtMessage.Text;
            buffer = Encoding.Unicode.GetBytes(msg);
            client.Send(buffer, buffer.Length, hostname, servierPort);

            Thread tr = new Thread(startServier);
            tr.Start();


            
        }
           
        private void startServier()
        {
            // portnumber.hostname.msg
            endPoint = new IPEndPoint(IPAddress.Any, 0);
            buffer = client.Receive(ref endPoint);
            neWmsg = Encoding.Unicode.GetString(buffer);
            writeLog(neWmsg);

        }
        private void txtLog_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void writeLog(string msg)
        {
            MethodInvoker inv = new MethodInvoker(delegate { txtLog.AppendText("Server said :" + neWmsg + Environment.NewLine); });
            this.BeginInvoke(inv);
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
