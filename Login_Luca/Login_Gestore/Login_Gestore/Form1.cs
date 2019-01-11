using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Gestore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox1_Username.Text = "";
            textBox2_Password.Text = "";
        }

        private void textBox1_Username_Enter(object sender, EventArgs e)
        {
            if (textBox1_Username.Text == "Username")
            {
                textBox1_Username.Text = "";
                textBox1_Username.ForeColor = Color.Black;
            }
        }

        private void textBox2_Password_Enter(object sender, EventArgs e)
        {
            if (textBox2_Password.Text == "Password")
            {
                textBox2_Password.Text = "";
                textBox2_Password.ForeColor = Color.Black;
            }
        }

        private void textBox2_Password_TextChanged(object sender, EventArgs e)
        {
            textBox2_Password.PasswordChar = '*';
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

