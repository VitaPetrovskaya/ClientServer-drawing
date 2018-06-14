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

namespace Client
{
    public partial class Client : Form
    {
        Boolean canDraw = false;
        Boolean stopDraw = true;
        List<Point> points = new List<Point>();
        Graphics g, h;
        Bitmap flag = new Bitmap(635, 479);


        TcpClient tcp_Client;
        Boolean b_Connected = false;
        Timer t_CheckData = new Timer();
        NetworkStream ns_Stream;


        public Client()
        {
            InitializeComponent();
            textBox_Receive.Enabled = false;

            t_CheckData.Interval = 100;
            t_CheckData.Tick += T_CheckData_Tick;
        }

        private void T_CheckData_Tick(object sender, EventArgs e)
        {
            if (b_Connected == true)
            {
                if (tcp_Client.Available > 0)
                {
                    try
                    {
                        Byte[] ba_Receive = new Byte[tcp_Client.Available];
                        ns_Stream = tcp_Client.GetStream();
                        ns_Stream.Read(ba_Receive, 0, tcp_Client.Available);
                        String s_Receive = Encoding.Default.GetString(ba_Receive);
                        textBox_Receive.Text = s_Receive;
                        DrawReceive(h, textBox_Receive.Text);
                        ns_Stream.Flush();
                    }
                    catch //(Exception ex)
                    {
                       // MessageBox.Show(ex.ToString());
                    }
                     
                }
            }
        }

        public void Draw(Graphics g, Color linecolor, int linewidth, Point p1, Point p2)
        {
            ns_Stream = tcp_Client.GetStream();
            Byte[] ba_Send = Encoding.Default.GetBytes(p1.X.ToString() + ";" + p1.Y.ToString() + ";" + p2.X.ToString() + ";" + p2.Y.ToString() + ";");
            ns_Stream.Write(ba_Send, 0, ba_Send.Length);

            g.DrawLine(new Pen(linecolor, linewidth), p1, p2);
            ns_Stream.Flush();
            pictureBoxClient.Image = flag;
        }

        public void DrawReceive(Graphics h, string s_Receive)
        {
            Color linecolor = Color.Orange;
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
            pictureBoxClient.Image = flag;
        }

        private void buttonDrawClient_Click(object sender, EventArgs e)
        {
            canDraw = !canDraw;
        }

        private void pictureBoxClient_MouseDown(object sender, MouseEventArgs e)
        {
            if (canDraw)
            {
                stopDraw = false;
                points.Add(new Point(e.X, e.Y));
            }
        }

        private void pictureBoxClient_MouseMove(object sender, MouseEventArgs e)
        {
            if (canDraw && !(stopDraw))
            {
                points.Add(new Point(e.X, e.Y));
                Draw(g, Color.DarkBlue, 2, points[points.Count-2], points[points.Count-1]);
            }
        }

        private void pictureBoxClient_MouseUp(object sender, MouseEventArgs e)
        {
            stopDraw = true;
            points.Clear();
        }

        private void labelConnect_MouseEnter(object sender, EventArgs e)
        {
            labelConnect.ForeColor = Color.White;
        }

        private void labelConnect_MouseLeave(object sender, EventArgs e)
        {
            labelConnect.ForeColor = Color.Orange;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            g = Graphics.FromImage(flag);
            h = Graphics.FromImage(flag);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            h.Clear(Color.White);
            pictureBoxClient.Image = flag;
        }

        private void labelConnect_Click(object sender, EventArgs e)
        {
            labelConnect.Enabled = false;
            tcp_Client = new TcpClient();
            tcp_Client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3333));
            if (tcp_Client.Connected == true)
            {
                labelConnection.Text = "Connected";
                labelConnection.ForeColor = Color.LimeGreen;
                b_Connected = true;
                t_CheckData.Start();
            }
            else
            {
                labelConnection.Text = "NOT CONNECTED";
                labelConnection.ForeColor = Color.Crimson;
            }
        }
    }
}
