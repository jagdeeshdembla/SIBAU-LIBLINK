﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIBAU_liblink
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Logout_btn_MouseEnter(object sender, EventArgs e)
        {
            this.Logout_btn.BackColor = Color.Gainsboro;
            this.pictureBox8.BackColor = Color.Gainsboro;

        }

        private void Logout_btn_MouseLeave(object sender, EventArgs e)
        {
            this.Logout_btn.BackColor= Color.Transparent;
            this.pictureBox8.BackColor= Color.White;
        }
    }
}
