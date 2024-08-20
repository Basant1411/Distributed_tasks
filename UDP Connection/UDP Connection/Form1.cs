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
    public partial class Form1 : Form
    {
        UdpClient servier;
        IPEndPoint endPoint;
        Form2 newClient;
        byte[] buffer;
        string[] msg;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnNewClient_Click(object sender, EventArgs e)
        {
            newClient = new Form2();
            newClient.Show();
        }

        private void btnStartServier_Click(object sender, EventArgs e)
        {
            servier = new UdpClient(int.Parse(txtServierPort.Text));
            endPoint = new IPEndPoint(IPAddress.Any, 0);
            writeLog("servier started.......");

            Thread tr = new Thread(startServier);
            tr.Start();
            btnStartServier.Enabled = false;
        }
        private void startServier()
        {
                // recived
                // portnumber.hostname.msg
                buffer = servier.Receive(ref endPoint);
                msg = Encoding.Unicode.GetString(buffer).Split('.');
                writeLog("Client at Port :" + msg[0]);
                writeLog("Client at Host :" + msg[1]);
                writeLog("Client need :"    + msg[2]);
        }

        private void writeLog(string msg)
        {
            MethodInvoker inv = new MethodInvoker(delegate { txtLog.AppendText(msg + Environment.NewLine); });
            this.BeginInvoke(inv);
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            // Get the message from the text box.
            string message = textBox1.Text;

            // Send the message to the client.
            buffer = Encoding.Unicode.GetBytes(message);
            servier.Send(buffer, buffer.Length, msg[1], int.Parse(msg[0]));
        }
    }
}
