using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_Projekt_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        JanauschLIB Janausch = new JanauschLIB();
        private void StartBut_Click(object sender, EventArgs e)
        {
            Janausch.TestPing(IPAddress.Parse(IpBox.Text));
            Janausch.TestPingPort(IPAddress.Parse(IpBox.Text), 80);
            Console.WriteLine(Janausch.GetLocalIPAddress());
        }
    }
}
