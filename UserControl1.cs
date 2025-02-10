using System.Data;
using System.Data.SqlClient;

namespace SIBAU_liblink
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            if (textBox1.PlaceholderText == "Username")
            {
                textBox1.PlaceholderText = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.PlaceholderText == "")
            {
                textBox1.PlaceholderText = "Username";
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
        private void button1_Click(object sender, EventArgs e)
        {
            String dcon = "Data Source=PC;Initial Catalog=ComboLogin;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dcon);
            SqlCommand cmd = new SqlCommand("select * from Login where Username = '" + textBox1.Text + "'and Password = '" + textBox2.Text + "'", con);
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
                        MessageBox.Show("You Are Login as " + dt.Rows[i][2]);
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
        private void eye_Click(object sender, EventArgs e)
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
                eye.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.White;

        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.White;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            this.label4.ForeColor = Color.Blue;
        }
        private void label4_MouseLeave(object sender, EventArgs e)
        {
            this.label4.ForeColor = Color.DarkSlateGray;
        }

        private void label2_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();

            f1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Login_Form login = new Login_Form();
            //UserControl1 control1 = new UserControl1();

            login.Hide();
            //control1.Hide();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
