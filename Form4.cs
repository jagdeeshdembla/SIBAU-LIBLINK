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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

       
    }
}
