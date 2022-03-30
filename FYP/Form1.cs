using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Control.SetIntial(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Control.Minimize(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Control.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void UserBox_Enter(object sender, EventArgs e)
        {
            if(UserBox.Text== "Username (Email)")
            {
                UserBox.Text = "";
            }
        }

        private void UserBox_Leave(object sender, EventArgs e)
        {
            if (UserBox.Text == "")
            {
                UserBox.Text = "Username (Email)";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text=="Password")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Password";
            }
        }
    }
}