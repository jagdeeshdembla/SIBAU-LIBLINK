namespace SIBAU_liblink
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox3 = new PictureBox();
            comboBox1 = new ComboBox();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            button1 = new Button();
            hidden = new PictureBox();
            eye = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hidden).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 138);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.MouseLeave += textBox1_MouseLeave;
            textBox1.MouseHover += textBox1_MouseHover;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(77, 183);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(143, 23);
            textBox2.TabIndex = 3;
            textBox2.MouseLeave += textBox2_MouseLeave;
            textBox2.MouseHover += textBox2_MouseHover;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(23, 183);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Student", "Faculty" });
            comboBox1.Location = new Point(77, 229);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(143, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "(Select type)";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(23, 229);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(119, 257);
            label4.Name = "label4";
            label4.Size = new Size(99, 13);
            label4.TabIndex = 8;
            label4.Text = "Forget Password?";
            label4.Click += label4_Click;
            label4.MouseEnter += label4_MouseEnter;
            label4.MouseLeave += label4_MouseLeave;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(13, 290);
            button1.Name = "button1";
            button1.Size = new Size(214, 38);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // hidden
            // 
            hidden.Cursor = Cursors.Hand;
            hidden.Image = (Image)resources.GetObject("hidden.Image");
            hidden.Location = new Point(199, 188);
            hidden.Name = "hidden";
            hidden.Size = new Size(17, 15);
            hidden.SizeMode = PictureBoxSizeMode.Zoom;
            hidden.TabIndex = 10;
            hidden.TabStop = false;
            hidden.Click += hidden_Click;
            // 
            // eye
            // 
            eye.Cursor = Cursors.Hand;
            eye.Image = (Image)resources.GetObject("eye.Image");
            eye.Location = new Point(199, 188);
            eye.Name = "eye";
            eye.Size = new Size(17, 15);
            eye.SizeMode = PictureBoxSizeMode.Zoom;
            eye.TabIndex = 11;
            eye.TabStop = false;
            eye.Click += eye_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(94, 73);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 1;
            label1.Text = "Login";
            label1.Click += label1_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 333);
            label2.Name = "label2";
            label2.Size = new Size(114, 13);
            label2.TabIndex = 12;
            label2.Text = "Create new account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(136, 332);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(47, 15);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(eye);
            Controls.Add(pictureBox1);
            Controls.Add(hidden);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Name = "UserControl1";
            Size = new Size(246, 403);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)hidden).EndInit();
            ((System.ComponentModel.ISupportInitialize)eye).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox3;
        private ComboBox comboBox1;
        private PictureBox pictureBox4;
        private Label label4;
        private Button button1;
        private PictureBox hidden;
        private PictureBox eye;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}
