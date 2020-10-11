using Login.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class colentor : Form, InterCambio
    {
        public colentor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InterCambio.log.User = textBox1.Text;
            InterCambio.log.Pass = textBox2.Text;

            Form1 j = new Form1();
            j.Show();

        }
    }
}
