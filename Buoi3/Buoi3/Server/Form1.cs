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

namespace Server
{
    public partial class Form1 : Form
    {
        Socket server;
        Socket client;
        byte[] data;

        private bool btn1clicked = false;
        private bool btn2clicked = false;
        private bool btn3clicked = false;
        int num;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
            server.Bind(ipep);
            server.Listen(10);
            client = server.Accept();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt1.Text = "Kéo";
            btn1clicked = true;
            btn2clicked = false;
            btn3clicked = false;
            send();
            receive();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Text = "Bao";
            btn1clicked = false;
            btn2clicked = true;
            btn3clicked = false;
            send();
            receive();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt1.Text = "Búa";
            btn1clicked = false;
            btn2clicked = false;
            btn3clicked = true;
            send();
            receive();
        }
        public void send()
        {
            if (btn1clicked == true)
            {
                num = 0;
                data = Encoding.ASCII.GetBytes(num.ToString());
                client.Send(data);
            }
            if (btn2clicked == true)
            {
                num = 1;
                data = Encoding.ASCII.GetBytes(num.ToString());
                client.Send(data);
            }
            if (btn3clicked == true)
            {
                num = 2;
                data = Encoding.ASCII.GetBytes(num.ToString());
                client.Send(data);
            }
        }
        public void receive()
        {
            data = new byte[1024];

            if (data != null)
            {
                client.Receive(data);
                int data1 = Convert.ToInt32(Encoding.ASCII.GetString(data));
                if (btn1clicked)
                {
                    if (data1 == 0)
                        txt2.Text = "Hòa";
                    if (data1 == 1)
                        txt2.Text = "Thắng";
                    if (data1 == 2)
                        txt2.Text = "Thua";

                }
                if (btn2clicked)
                {
                    if (data1 == 0)
                        txt2.Text = "Thua";
                    if (data1 == 1)
                        txt2.Text = "Hòa";
                    if (data1 == 2)
                        txt2.Text = "Thắng";
                }
                if (btn3clicked)
                {
                    if (data1 == 0)
                        txt2.Text = "Thắng";
                    if (data1 == 1)
                        txt2.Text = "Thua";
                    if (data1 == 2)
                        txt2.Text = "Hòa";
                }
            }
        }
    }
}
