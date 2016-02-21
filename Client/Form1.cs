using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            localhost.Service1 myService = new localhost.Service1();
            myService.Credentials = System.Net.CredentialCache.DefaultCredentials;
            textBox1.Text = myService.GetInformation();
            myService.Dispose();
        }
    }
}
