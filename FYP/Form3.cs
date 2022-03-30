using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace FYP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Control.SetIntial(this);


            MangStd.Hide();
            MangPro.Hide();
            MangTeach.Hide();
            StdGroup.Hide();
            AssPro.Hide();
            AssAdvis.Hide();
            Evalua.Hide();
            MarkEval.Hide();
            panel6.Hide();
            panel7.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void roundPictures1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            f4.tabControl1.SelectTab(0);
            f4.MangSdPan.Show();
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Control.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Control.Minimize(this);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            Control.DoMaximizze(this, lbl,panel6,panel7);
            
        }
        

        private void Hover(Label lbl,bool b,RoundPictures p)
        {
            if(b == true)
            {
                p.BackColor = Color.DarkGray;
                lbl.Show();
            }
            else
            {
                p.BackColor = Color.FromArgb(215, 228, 242);
                lbl.Hide();
            }
        }

        private void roundPictures1_MouseEnter(object sender, EventArgs e)
        {
            Hover(MangStd, true, roundPictures1);
        }

        private void roundPictures1_MouseLeave(object sender, EventArgs e)
        {
            Hover(MangStd, false, roundPictures1);
        }

        private void roundPictures2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            f4.tabControl1.SelectTab(1);
            f4.MangProPan.Show();
            this.Close();
        }

        private void roundPictures2_MouseEnter(object sender, EventArgs e)
        {
            Hover(MangPro, true, roundPictures2);
        }

        private void roundPictures2_MouseLeave(object sender, EventArgs e)
        {
            Hover(MangPro, false, roundPictures2);
        }

        private void roundPictures3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            f4.tabControl1.SelectTab(2);
            f4.MangAdvi.Show();
            this.Close();
        }

        private void roundPictures3_MouseEnter(object sender, EventArgs e)
        {
            Hover(MangTeach, true, roundPictures3);
        }

        private void roundPictures3_MouseLeave(object sender, EventArgs e)
        {
            Hover(MangTeach, false, roundPictures3);
        }

        private void roundPictures4_Click(object sender, EventArgs e)
        {
            Hover(StdGroup, true, roundPictures4);
            Form4 f4 = new Form4();
            f4.Show();
            f4.tabControl1.SelectTab(3);
            f4.StdGroups.Show();
            this.Close();
        }

        private void roundPictures4_MouseEnter(object sender, EventArgs e)
        {
            Hover(StdGroup, true, roundPictures4);
        }

        private void roundPictures4_MouseLeave(object sender, EventArgs e)
        {
            Hover(StdGroup, false, roundPictures4);
        }

        private void roundPictures5_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            f4.tabControl1.SelectTab(1);
            f4.MangProPan.Show();
            f4.pictureBox11_Click_1(f4.pictureBox11, EventArgs.Empty);
            this.Close();
        }

        private void roundPictures5_MouseEnter(object sender, EventArgs e)
        {
            Hover(AssPro, true, roundPictures5);
        }

        private void roundPictures5_MouseLeave(object sender, EventArgs e)
        {
            Hover(AssPro, false, roundPictures5);
        }

        private void roundPictures6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            f4.tabControl1.SelectTab(2);
            f4.MangAdvi.Show();
            f4.pictureBox21_Click(f4.pictureBox21, EventArgs.Empty);
            this.Close();
            ////
        }

        private void roundPictures6_MouseEnter(object sender, EventArgs e)
        {
            Hover(AssAdvis, true, roundPictures6);
        }

        private void roundPictures6_MouseLeave(object sender, EventArgs e)
        {
            Hover(AssAdvis, false, roundPictures6);
        }

        private void roundPictures7_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            f4.tabControl1.SelectTab(6);
            f4.MangEvaluation.Show();
            this.Close();
        }

        private void roundPictures7_MouseEnter(object sender, EventArgs e)
        {
            Hover(Evalua, true, roundPictures7);
        }

        private void roundPictures7_MouseLeave(object sender, EventArgs e)
        {
            Hover(Evalua, false, roundPictures7);
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundPictures8_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            f4.tabControl1.SelectTab(6);
            f4.MangEvaluation.Show();
            f4.pictureBox26_Click(f4.pictureBox26, EventArgs.Empty);
            this.Close();
        }

        private void roundPictures8_MouseEnter(object sender, EventArgs e)
        {
            Hover(MarkEval, true, roundPictures8);
        }

        private void roundPictures8_MouseLeave(object sender, EventArgs e)
        {
            Hover(MarkEval, false, roundPictures8);
        }

        private void tableLayoutPanel9_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void tableLayoutPanel9_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(27, 76, 47);
            panel5.BackColor = Color.FromArgb(178, 181, 40);
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(27, 76, 47);
            panel2.BackColor = Color.FromArgb(178, 181, 40);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
       
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void MangStd_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            f4.tabControl1.SelectTab(0);
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            f4.tabControl1.SelectTab(7);
            this.Close();
        }
    }
}
