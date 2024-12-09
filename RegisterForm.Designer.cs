namespace StyroPackPro
{
    partial class RegisterForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            close = new Label();
            register_showPass = new CheckBox();
            pictureBox4 = new PictureBox();
            register_cPassword = new TextBox();
            label5 = new Label();
            register_label = new Label();
            label3 = new Label();
            login_btn = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            register_password = new TextBox();
            register_username = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // close
            // 
            close.AutoSize = true;
            close.BackColor = Color.Firebrick;
            close.ForeColor = Color.White;
            close.Location = new Point(755, 0);
            close.Name = "close";
            close.Size = new Size(14, 15);
            close.TabIndex = 11;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.BackColor = Color.FromArgb(224, 224, 224);
            register_showPass.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_showPass.Location = new Point(369, 294);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(124, 24);
            register_showPass.TabIndex = 25;
            register_showPass.Text = "Show Password";
            register_showPass.UseVisualStyleBackColor = false;
            register_showPass.CheckedChanged += register_showPass_CheckedChanged_1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(173, 265);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // register_cPassword
            // 
            register_cPassword.BackColor = Color.FromArgb(224, 224, 224);
            register_cPassword.Location = new Point(212, 265);
            register_cPassword.Name = "register_cPassword";
            register_cPassword.PasswordChar = '*';
            register_cPassword.Size = new Size(281, 23);
            register_cPassword.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkMagenta;
            label5.Location = new Point(333, 76);
            label5.Name = "label5";
            label5.Size = new Size(92, 22);
            label5.TabIndex = 22;
            label5.Text = "tyroPack";
            // 
            // register_label
            // 
            register_label.AutoSize = true;
            register_label.BackColor = Color.FromArgb(224, 224, 224);
            register_label.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_label.ForeColor = Color.FromArgb(128, 128, 255);
            register_label.Location = new Point(359, 387);
            register_label.Name = "register_label";
            register_label.Size = new Size(86, 20);
            register_label.TabIndex = 21;
            register_label.Text = "Sign In Here";
            register_label.Click += register_label_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(173, 387);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 20;
            label3.Text = "Already have an account?";
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.Violet;
            login_btn.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.Location = new Point(173, 324);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(320, 39);
            login_btn.TabIndex = 19;
            login_btn.Text = "SignUp";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(173, 236);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(173, 207);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(250, 52);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(107, 74);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(238, 154);
            label2.Name = "label2";
            label2.Size = new Size(169, 22);
            label2.TabIndex = 15;
            label2.Text = "Register Account";
            // 
            // register_password
            // 
            register_password.BackColor = Color.FromArgb(224, 224, 224);
            register_password.Location = new Point(212, 236);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(281, 23);
            register_password.TabIndex = 14;
            // 
            // register_username
            // 
            register_username.BackColor = Color.FromArgb(224, 224, 224);
            register_username.Location = new Point(212, 207);
            register_username.Name = "register_username";
            register_username.Size = new Size(281, 23);
            register_username.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(register_username);
            panel1.Controls.Add(register_showPass);
            panel1.Controls.Add(register_cPassword);
            panel1.Controls.Add(register_password);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(register_label);
            panel1.Controls.Add(login_btn);
            panel1.Location = new Point(51, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(673, 436);
            panel1.TabIndex = 26;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(768, 513);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label close;
        private CheckBox register_showPass;
        private PictureBox pictureBox4;
        private TextBox register_cPassword;
        private Label label5;
        private Label register_label;
        private Label label3;
        private Button login_btn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private Label label2;
        private TextBox register_password;
        private TextBox register_username;
        private Panel panel1;
    }
}