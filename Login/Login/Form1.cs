
using Login.Dominio;
using Login.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form, InterCambio
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
           String ho= InterCambio.log.Pass;
            String h2=InterCambio.log.User;

            InterCambio.log.UserComparer = textBox1.Text;
            InterCambio.log.PassComparer = textBox2.Text;
            
            clsLogin ver = new clsLogin();
            bool ok= ver.verificar(InterCambio.log);

            if (ok == true)
            {
                MessageBox.Show("Welcome ");
            }
            else {
                MessageBox.Show("Stop");
            }


        }

        
    }
}
