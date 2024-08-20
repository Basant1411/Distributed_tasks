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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Socket server;
        List<Socket> Clients;
        public Form1()
        {
            InitializeComponent();
            Clients = new List<Socket>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void UpdateGui(bool isconnected)
        {
            btnstartserver.Enabled = !isconnected;
            btnsend.Enabled = isconnected;
            lblstatus.Text = isconnected ? "Connected" : "Disconnected";
            lblstatus.ForeColor = isconnected ? Color.Green : Color.Red;
        }

        private void btnstartserver_Click(object sender, EventArgs e)
        {
            server = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            int portnum = int.Parse(txtserverport.Text);
            server.Bind(new IPEndPoint(IPAddress.Any,portnum));
            server.Listen(5);
            UpdateGui(true);
            Writelog("Server Started..");
            server.BeginAccept(new AsyncCallback(OnClientConnect),null);
        }
        private void OnClientConnect(IAsyncResult ar)
        {
            Socket client = server.EndAccept(ar);
            Clients.Add(client);
            ReadytoSend(client);
            server.BeginAccept(new AsyncCallback(OnClientConnect), null);
        }
        private void ReadytoSend(Socket client)
        {
            socketPacket packet = new socketPacket(client);
            client.BeginReceive(packet.buffer,0,packet.buffer.Length,SocketFlags.None,new AsyncCallback(OnRecieve),packet);
        }
        private void OnRecieve(IAsyncResult ar)
        {
            socketPacket packet = (socketPacket)ar.AsyncState;
            packet.client.EndReceive(ar);
            string msg = Encoding.Unicode.GetString(packet.buffer);
            Writelog(msg);
            ReadytoSend(packet.client);

        }
        private void Writelog(string msg)
        {
            MethodInvoker inv = new MethodInvoker(delegate { txtlog.AppendText(msg + Environment.NewLine); });
            this.BeginInvoke(inv);
        }

        private void btnnewclient_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            string msg = txtSendtoAllClients.Text;
            byte[] buffer = Encoding.Unicode.GetBytes(msg);

            foreach (Socket client in Clients)
            {
                if (listBox1.SelectedItem != null)
                {



                    client.Send(buffer);
                    break;
                
                }
                else
                {
                    client.Send(buffer);
                }
            }
            
        }
    }
}
