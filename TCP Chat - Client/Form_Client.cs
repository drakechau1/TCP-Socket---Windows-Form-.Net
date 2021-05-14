using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace TCP_Chat___Client
{
    public partial class Form_Client : Form
    {
        TcpClient client;
        IPAddress remote_ip;
        int remote_port;
        IPEndPoint remote_ipe;
        NetworkStream stream;
        StreamWriter writer;
        StreamReader reader;
        

        /// <summary>
        /// Child functions
        /// </summary>

        public delegate void Add_Items(ListBox lb, string message);
        public void Infor_Message(ListBox lb, string message)
        {

            if (lb.InvokeRequired)
            {
                Add_Items d = new Add_Items(Infor_Message);
                this.Invoke(d, new object[] { lb, message });
            }
            else
            {
                lb.Items.Add(message);
            }
        }

        public void ShowERROR(string error)
        {
            MessageBox.Show(error, "Error");
        }

        public void Send_Message(string message)
        {
            try
            {
                writer.AutoFlush = true;
                writer.WriteLine(message);
                Infor_Message(lb_message, message);
            }
            catch(Exception ex)
            {
                ShowERROR(ex.Message);
            }
        }

        /// <summary>
        /// Main fuctions
        /// </summary>
        
        public Form_Client()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                remote_ip = IPAddress.Parse(txt_remoteIP.Text);
                string text = txt_remotePort.Text;
                remote_port = int.Parse(text);

                remote_ipe = new IPEndPoint(remote_ip, remote_port);

                client = new TcpClient();
                client.Connect(remote_ipe);

                stream = client.GetStream();
                writer = new StreamWriter(stream);
                reader = new StreamReader(stream);

                string inform = $"Connected to {remote_ipe.Address} : {remote_ipe.Port} ";
                Infor_Message(lb_message, inform);

                btn_connect.Enabled = false;
                btn_disconnect.Enabled = true;
                btn_send.Enabled = true;
                btn_attachFile.Enabled = true;

                txt_message.Enabled = true;
                txt_remoteIP.Enabled = false;
                txt_remotePort.Enabled = false;
            }
            catch (Exception ex)
            {
                ShowERROR(ex.Message);
                Infor_Message(lb_message, "Connection was aborted");
            }
            finally
            {
                btn_clearMessage.Enabled = true;
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            Send_Message(txt_message.Text);
            txt_message.Text = string.Empty;
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                stream.Close();
                client.Close();

                Infor_Message(lb_message, "Disconnected");

                btn_connect.Enabled = true;
                btn_disconnect.Enabled = false;
                btn_attachFile.Enabled = false;
                btn_send.Enabled = false;
                btn_remove.Enabled = false;

                txt_message.Enabled = false;
                txt_remoteIP.Enabled = true;
                txt_remotePort.Enabled = true;
            }
            catch(SocketException ex)
            {
                ShowERROR(ex.Message);
            }
        }

        private void txt_clearMessage_Click(object sender, EventArgs e)
        {
            lb_message.Items.Clear();
            btn_clearMessage.Enabled = false;
        }

        private void btn_attachFile_Click(object sender, EventArgs e)
        {
            ///
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                label_attachFile.Text = ofd.FileName;

                btn_remove.Enabled = true;
                btn_attachFile.Enabled = false;
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            label_attachFile.Text = "No file attached curently";
            btn_attachFile.Enabled = true;
            btn_remove.Enabled = false;
        }
    }
}
