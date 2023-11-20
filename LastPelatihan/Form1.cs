using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastPelatihan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2ToggleSwitch1.Checked == true)
            {
                this.BackColor = Color.FromArgb(34, 36, 49);
                labelNigga.ForeColor = Color.White;
                label1.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                labelNigga.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Indonesia.Visible = true;
            Inggris.Visible = false;
        }



        private void Indonesia_Click(object sender, EventArgs e)
        {
            if (Indonesia.Visible == true)
            {
                label1.Text = "Selamat Datang di Aplikasi saya";
                Indonesia.Visible = false;
            }
        }

        private void Inggris_Click(object sender, EventArgs e)
        {
             if(Inggris.Visible == false)
            {
                label1.Text = "Welcome To My Application";
                Inggris.Visible = true;
            }
        }
    }
}
