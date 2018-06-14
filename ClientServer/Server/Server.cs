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
using System.Windows;

namespace Server
{
    public partial class Server : Form
    {
        Boolean canDraw = false;
        Boolean stopDraw = true;
        List<Point> points = new List<Point>();
        Graphics g, h;
        Bitmap flag = new Bitmap(635, 479);



        public Server()
        {
            InitializeComponent();
        }

        public void Draw(Graphics g, Color linecolor, int linewidth, Point p1, Point p2)
        {
            ns_Stream = tcp_Client.GetStream();
            Byte[] ba_Send = Encoding.Default.GetBytes(p1.X.ToString()+";"+p1.Y.ToString()+";"+ p2.X.ToString() + ";" + p2.Y.ToString()+";");
            ns_Stream.Write(ba_Send, 0, ba_Send.Length);

            g.DrawLine(new Pen(linecolor, linewidth), p1, p2);
            ns_Stream.Flush();
            pictureBoxServer.Image = flag;
        }

        public void DrawReceive(Graphics h, string s_Receive)
        {
            Color linecolor = Color.DarkBlue;
            int linewidth = 2;
            string strX, strY;
            Point p1 = new Point();
            Point p2 = new Point();
            Pen p = new Pen(linecolor, linewidth);

            while (s_Receive != "")
            {
                strX = s_Receive.Substring(0, s_Receive.IndexOf(";"));
                s_Receive = s_Receive.Remove(0, s_Receive.IndexOf(";") + 1);
                strY = s_Receive.Substring(0, s_Receive.IndexOf(";"));
                s_Receive = s_Receive.Remove(0, s_Receive.IndexOf(";") + 1);
                p1.X = Int32.Parse(strX);
                p1.Y = Int32.Parse(strY);

                strX = s_Receive.Substring(0, s_Receive.IndexOf(";"));
                s_Receive = s_Receive.Remove(0, s_Receive.IndexOf(";") + 1);
                strY = s_Receive.Substring(0, s_Receive.IndexOf(";"));
                s_Receive = s_Receive.Remove(0, s_Receive.IndexOf(";") + 1);
                p2.X = Int32.Parse(strX);
                p2.Y = Int32.Parse(strY);

                h.DrawLine(p, p1, p2);
                ns_Stream.Flush();
                
            }
            pictureBoxServer.Image = flag;

        }


        private void labelStart_MouseEnter(object sender, EventArgs e)
        {
            labelStart.ForeColor = Color.White;
        }

        private void labelStart_MouseLeave(object sender, EventArgs e)
        {
            labelStart.ForeColor = Color.Orange;
        }

        private void pictureBoxServer_MouseDown(object sender, MouseEventArgs e)
        {
            if (canDraw)
            {
                stopDraw = false;
                points.Add(new Point(e.X, e.Y));
            }
        }

        private void pictureBoxServer_MouseMove(object sender, MouseEventArgs e)
        {
            if (canDraw && !(stopDraw))
            {
                points.Add(new Point(e.X, e.Y));
                Draw(g, Color.Orange, 2, points[points.Count - 2], points[points.Count - 1]);
            }
        }

        private void buttonDrawServer_Click(object sender, EventArgs e)
        {
            canDraw = !canDraw;
        }

        private void pictureBoxServer_MouseUp(object sender, MouseEventArgs e)
        {
            stopDraw = true;
            points.Clear();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            g = Graphics.FromImage(flag);
            h = Graphics.FromImage(flag);
            textBox_Receive.Enabled = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            h.Clear(Color.White);
            pictureBoxServer.Image = flag;
        }

        bool b_ServerStarted = false;
        bool b_Connected = false;
        Thread thr_Server;
        TcpListener tcp_Server;
        TcpClient tcp_Client;
        NetworkStream ns_Stream;
        delegate void del_ConnectManager(String Operation, Object Data);

        // server start listen to client messages
        void rv_ServerStartListening(object sender)
        {
            tcp_Server = new TcpListener(IPAddress.Parse("127.0.0.1"), 3333);
            tcp_Server.Start();
            tcp_Client = tcp_Server.AcceptTcpClient();
            ns_Stream = new NetworkStream(tcp_Client.Client);
            del_ConnectManager ndel_CS = new del_ConnectManager(v_ConnectManager);
            this.Invoke(ndel_CS, new object[] { "Connection", true });
            b_Connected = true;
            while (b_Connected == true)
            {
                if (tcp_Client.Available > 0)
                {
                    Byte[] ba_Receive = new Byte[tcp_Client.Available];
                    ns_Stream = tcp_Client.GetStream();
                    ns_Stream.Read(ba_Receive, 0, tcp_Client.Available);
                    String s_Receive = Encoding.Default.GetString(ba_Receive);
                    this.Invoke(ndel_CS, new object[] { "ReceiveData", s_Receive });
                    DrawReceive(h, textBox_Receive.Text);
                }
                Thread.Sleep(5);
            }
        }

        void v_ConnectManager(String s_Operation, Object o_Data)
        {
            switch (s_Operation)
            {
                case "Connection": labelConnection.Text = "Connected"; labelConnection.ForeColor = Color.LimeGreen; break;
                case "ReceiveData": textBox_Receive.Text = (String)o_Data; break;
            }
        }

        private void labelStart_Click(object sender, EventArgs e)
        {
            labelStart.Enabled = false;
            thr_Server = new Thread(new ParameterizedThreadStart(rv_ServerStartListening));
            thr_Server.Start();
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (b_ServerStarted == true)
            {
                tcp_Server.Stop();
                thr_Server.Abort();
            }
        }
    }
}
