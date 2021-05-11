using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace TCP_Chat___Server
{
    public partial class TCPServer : Form
    {
        Socket socket;
        Socket client;
        NetworkStream stream;

        IPAddress ip = IPAddress.Parse("127.0.0.1");
        int port = 8080;
        IPEndPoint ipe;

        Thread thread;
        /// <summary>
        /// functions
        /// </summary>

        public delegate void Add_Items(ListBox lb, string data);
        public void Infor_Message(ListBox lb, string data)
        {
            if (lb.InvokeRequired)
            {
                Add_Items d = new Add_Items(Infor_Message);
                this.Invoke(d, new object[] { lb, data });
            }
            else
            {
                try
                {
                    lb.Items.Add(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        bool SocketConnected(Socket s)
        {
            bool part1 = s.Poll(1000, SelectMode.SelectRead);
            bool part2 = (s.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }

        public void Server_Thread()
        {
            while(true)
            {
                client = socket.Accept();

                stream = new NetworkStream(client);
                var reader = new StreamReader(stream);

                Infor_Message(lb_message, "New client connected");

                while (SocketConnected(client))
                {

                    string text = reader.ReadLine();
                    if (text == string.Empty)
                    {
                        Console.WriteLine("text is null");
                        continue;
                    }

                    if (SocketConnected(client))
                    {
                        Infor_Message(lb_message, "Client: " + text);
                    }
                }

                Infor_Message(lb_message, "Client disconnected");

                stream.Close();
                client.Close();
            }
        }

        /// <summary>
        /// main programing
        /// </summary>
        public TCPServer()
        {
            InitializeComponent();
        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            ipe = new IPEndPoint(ip, port);

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socket.Bind(ipe);
            socket.Listen(-1);

            thread = new Thread(new ThreadStart(Server_Thread));
            thread.Start();

            Infor_Message(lb_message, $"Listening port {port}");

            btn_listen.Enabled = false;
            btn_close.Enabled = true;
        }

        private void btn_clearmessage_Click(object sender, EventArgs e)
        {
            lb_message.Items.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            socket.Close();
            thread.Abort();

            Infor_Message(lb_message, "Connection closed");

            btn_listen.Enabled = true;
            btn_close.Enabled = false;
        }
    }
}
