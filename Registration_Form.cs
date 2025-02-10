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
    public partial class Registration_Form : Form
    {
        ToolTip tooltip = new ToolTip();
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void textBox5_MouseHover(object sender, EventArgs e)
        {
           
            if (textBox5.PlaceholderText == "First Name")
            {
                textBox5.PlaceholderText = "";
                textBox5.ForeColor = Color.Black;
                tooltip.SetToolTip(textBox5,"Enter Your Firt Name");
               
            }
        }

        private void textBox5_MouseLeave(object sender, EventArgs e)
        {
            if (textBox5.PlaceholderText == "")
            {
                textBox5.PlaceholderText = "First Name";
                textBox5.ForeColor = Color.Black;

                
            }
        }

        private void textBox7_MouseHover(object sender, EventArgs e)
        {
            if (textBox7.PlaceholderText == "Last Name")
            {
                textBox7.PlaceholderText = "";
                textBox7.ForeColor = Color.Black;
                tooltip.SetToolTip(textBox7, "Enter Your Last Name");

            }

        }

        private void textBox7_MouseLeave(object sender, EventArgs e)
        {
            if (textBox7.PlaceholderText == "")
            {
                textBox7.PlaceholderText = "Last Name";
                textBox7.ForeColor = Color.Black;
                
            }

        }

        private void textBox4_MouseHover(object sender, EventArgs e)
        {
            if (textBox4.PlaceholderText == "CMS-ID")
            {
                textBox4.PlaceholderText = "";
                textBox4.ForeColor = Color.Black;
                tooltip.SetToolTip(textBox4, "Enter Your CMS-ID");

            }


        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            if (textBox4.PlaceholderText == "")
            {
                textBox4.PlaceholderText = "CMS-ID";
                textBox4.ForeColor = Color.Black;
                
            }

        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            if (textBox3.PlaceholderText == "Email")
            {
                textBox3.PlaceholderText = "";
                textBox3.ForeColor = Color.Black;
                tooltip.SetToolTip(textBox3, "Enter Your Email");

            }
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            if (textBox3.PlaceholderText == "")
            {
                textBox3.PlaceholderText = "Email";
                textBox3.ForeColor = Color.Black;
                
            }

        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            if (textBox2.PlaceholderText == "Password")
            {
                textBox2.PlaceholderText = "";
                textBox2.ForeColor = Color.Black;
                tooltip.SetToolTip(textBox2, "Enter Your Password");
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

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            if (textBox1.PlaceholderText == "Comfrim Password")
            {
                textBox1.PlaceholderText = "";
                textBox1.ForeColor = Color.Black;
                tooltip.SetToolTip(textBox1, "Enter Your Comfrim Password");
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.PlaceholderText == "")
            {
                textBox1.PlaceholderText = "Comfrim Password";
                textBox1.ForeColor = Color.Black;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Form login = new Login_Form();
            login.Show();
            Registration_Form register = new Registration_Form();
            register.Hide();
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
            String comfrim_password = textBox1.Text;
            String hashedcomfrim_Password = HashPassword(password);


            String Gender = "";
            if (radioButton1.Checked)
            {
                Gender = radioButton1.Text;
            }
            else { 
                Gender = radioButton2.Text;
            }
            String dcon = "Data Source=PC;Initial Catalog=Library_Management_System;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            SqlCommand cmd = new SqlCommand(@"INSERT INTO UserInfo ([First_Name]
           ,[Last_Name]
           ,[CMS_ID]
           ,[Email]
           ,[Password]
           ,[Comfrim_Password]
           ,[Usertype]
           ,[Gender])
           VALUES 
           ('"+textBox5.Text+ "','"+textBox7.Text+ "','"+textBox4.Text+ "','"+textBox3.Text+ "',"+
           "'"+hashedPassword+"','"+hashedcomfrim_Password+"','"+comboBox1.SelectedItem.ToString()+ "','"+Gender+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Register Successfully");

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.White;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '*')
            {
                hidden1.BringToFront();
                textBox1.PasswordChar = '\0';
            }
        }

        private void hidden1_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '\0')
            {
                pictureBox1.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
