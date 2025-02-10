using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SIBAU_liblink
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder hash = new StringBuilder();

                foreach (byte b in bytes)
                {
                    hash.Append(b.ToString("x2")); // Convert to hexadecimal
                }

                return hash.ToString();
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            String password = textBox2.Text;
            String hashedPassword = HashPassword(password);

            String dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            SqlCommand cmd = new SqlCommand("select * from UserInfo where CMS_ID = '" + textBox1.Text + "'and Password = '" +hashedPassword + "'", con);
            SqlDataAdapter apdt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apdt.Fill(dt);
            String combItemValue = comboBox1.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (dt.Rows[i]["Usertype"].ToString() == combItemValue)
                    {
                        MessageBox.Show("You Are Login as " + dt.Rows[i][6]);
                        if (comboBox1.SelectedIndex == 0)
                        {
                            Form2 f2 = new Form2();
                            f2.Show();
                            this.Hide();
                        }
                        else if (comboBox1.SelectedIndex == 1)
                        {
                            Form3 f3 = new Form3();
                            f3.Show();
                            this.Hide();
                        }
                        else
                        {
                            Form4 f4 = new Form4();
                            f4.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                hidden.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }

        private void hidden_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                pictureBox2.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            this.label4.ForeColor = Color.Blue;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            this.label4.ForeColor = Color.DarkSlateGray;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.btn_lg1.ForeColor = Color.Black;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.btn_lg1.ForeColor = Color.White;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration_Form register = new Registration_Form();
            register.Show();
            Login_Form login = new Login_Form();
            login.Hide();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            if (textBox1.PlaceholderText == "CMS-ID")
            {
                textBox1.PlaceholderText = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.PlaceholderText == "")
            {
                textBox1.PlaceholderText = "CMS-ID";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            if (textBox2.PlaceholderText == "Password")
            {

                textBox2.PlaceholderText = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (textBox2.PlaceholderText == "")
            {
                textBox2.PlaceholderText = "Password";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
           
        }
    }
}

