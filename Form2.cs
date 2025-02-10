using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.LightBlue;
            this.pictureBox3.BackColor = Color.LightBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Transparent;
            this.pictureBox3.BackColor = Color.White;
        }
        private void Circulation_btn_MouseEnter_1(object sender, EventArgs e)
        {
            this.Circulation_btn.BackColor = Color.LightBlue;
            this.pictureBox4.BackColor = Color.LightBlue;
        }
        private void Circulation_btn_MouseLeave_1(object sender, EventArgs e)
        {
            this.Circulation_btn.BackColor = Color.Transparent;
            this.pictureBox4.BackColor = Color.White;
        }
        private void Cataloging_btn_MouseEnter(object sender, EventArgs e)
        {
            this.Cataloging_btn.BackColor = Color.LightBlue;
            this.pictureBox5.BackColor = Color.LightBlue;
        }

        private void Cataloging_btn_MouseLeave(object sender, EventArgs e)
        {
            this.Cataloging_btn.BackColor = Color.Transparent;
            this.pictureBox5.BackColor = Color.White;
        }

        private void Serials_btn_MouseEnter(object sender, EventArgs e)
        {
            this.Serials_btn.BackColor = Color.LightBlue;
            this.pictureBox6.BackColor = Color.LightBlue;
        }   

        private void Serials_btn_MouseLeave(object sender, EventArgs e)
        {
            this.Serials_btn.BackColor = Color.Transparent;
            this.pictureBox6.BackColor = Color.White;
        }

        private void Lists_btn_MouseEnter(object sender, EventArgs e)
        {
            this.Lists_btn.BackColor = Color.LightBlue;
            this.pictureBox7.BackColor = Color.LightBlue;
        }

        private void Lists_btn_MouseLeave(object sender, EventArgs e)
        {
            this.Lists_btn.BackColor = Color.Transparent;
            this.pictureBox7.BackColor = Color.White;
        }

        private void Reports_btn_MouseEnter(object sender, EventArgs e)
        {
            this.Reports_btn.BackColor = Color.LightBlue;
            this.pictureBox2.BackColor = Color.LightBlue;

        }

        private void Reports_btn_MouseLeave(object sender, EventArgs e)
        {
            this.Reports_btn.BackColor = Color.Transparent;
            this.pictureBox2.BackColor = Color.White;
        }

        private void About_btn_MouseEnter(object sender, EventArgs e)
        {
            this.About_btn.BackColor = Color.LightBlue;
            this.pictureBox9.BackColor = Color.LightBlue;
        }

        private void About_btn_MouseLeave(object sender, EventArgs e)
        {
            this.About_btn.BackColor = Color.Transparent;
            this.pictureBox9.BackColor = Color.White;

        }

        private void Circulation_btn_MouseLeave(object sender, EventArgs e)
        {
            this.Circulation_btn.BackColor = Color.Transparent;
            this.pictureBox4.BackColor = Color.White;
        }
    }
}
