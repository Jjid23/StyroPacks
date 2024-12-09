namespace StyroPackPro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            login_showPass = new CheckBox();
            label5 = new Label();
            register_label = new Label();
            label3 = new Label();
            login_btn = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            login_password = new TextBox();
            login_username = new TextBox();
            close = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(login_showPass);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(register_label);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(login_password);
            panel1.Controls.Add(login_username);
            panel1.Location = new Point(51, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(675, 410);
            panel1.TabIndex = 1;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showPass.Location = new Point(369, 259);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(124, 24);
            login_showPass.TabIndex = 10;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkMagenta;
            label5.Location = new Point(339, 54);
            label5.Name = "label5";
            label5.Size = new Size(92, 22);
            label5.TabIndex = 9;
            label5.Text = "tyroPack";
            // 
            // register_label
            // 
            register_label.AutoSize = true;
            register_label.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_label.ForeColor = Color.FromArgb(128, 128, 255);
            register_label.Location = new Point(369, 360);
            register_label.Name = "register_label";
            register_label.Size = new Size(92, 20);
            register_label.TabIndex = 8;
            register_label.Text = "Register Here";
            register_label.Click += register_label_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(173, 360);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 7;
            label3.Text = "Have no account yet?";
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.Violet;
            login_btn.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.Location = new Point(173, 289);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(320, 39);
            login_btn.TabIndex = 6;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(173, 219);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(173, 174);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(248, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(259, 119);
            label2.Name = "label2";
            label2.Size = new Size(141, 22);
            label2.TabIndex = 2;
            label2.Text = "Login Account";
            // 
            // login_password
            // 
            login_password.Location = new Point(212, 219);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(281, 23);
            login_password.TabIndex = 1;
            // 
            // login_username
            // 
            login_username.Location = new Point(212, 174);
            login_username.Name = "login_username";
            login_username.Size = new Size(281, 23);
            login_username.TabIndex = 0;
            // 
            // close
            // 
            close.AutoSize = true;
            close.BackColor = Color.Firebrick;
            close.ForeColor = Color.White;
            close.Location = new Point(755, 0);
            close.Name = "close";
            close.Size = new Size(14, 15);
            close.TabIndex = 10;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(768, 513);
            Controls.Add(close);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += LoginPanel_MouseDown;
            MouseMove += LoginPanel_MouseMove;
            MouseUp += LoginPanel_MouseUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label register_label;
        private Label label3;
        private Button login_btn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox login_password;
        private TextBox login_username;
        private Label close;
        private CheckBox login_showPass;
    }
}
