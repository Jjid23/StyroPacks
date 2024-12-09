namespace StyroPackPro
{
    partial class AdminAddUser
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            addUsers_addBtn = new Button();
            addUsers_clearBtn = new Button();
            addUsers_removeBtn = new Button();
            addUsers_updateBtn = new Button();
            label3 = new Label();
            addUsers_role = new ComboBox();
            addUsers_password = new TextBox();
            label2 = new Label();
            addUsers_username = new TextBox();
            label1 = new Label();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.FromArgb(95, 61, 204);
            guna2Panel2.Controls.Add(dataGridView1);
            guna2Panel2.Controls.Add(label5);
            guna2Panel2.CustomizableEdges = customizableEdges1;
            guna2Panel2.Location = new Point(316, 25);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel2.Size = new Size(569, 566);
            guna2Panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(95, 61, 204);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(13, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(540, 491);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(13, 19);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 9;
            label5.Text = "All User's Data";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(95, 61, 204);
            guna2Panel1.Controls.Add(addUsers_addBtn);
            guna2Panel1.Controls.Add(addUsers_clearBtn);
            guna2Panel1.Controls.Add(addUsers_removeBtn);
            guna2Panel1.Controls.Add(addUsers_updateBtn);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(addUsers_role);
            guna2Panel1.Controls.Add(addUsers_password);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(addUsers_username);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(24, 25);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(286, 566);
            guna2Panel1.TabIndex = 2;
            // 
            // addUsers_addBtn
            // 
            addUsers_addBtn.BackColor = Color.Violet;
            addUsers_addBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUsers_addBtn.Location = new Point(33, 301);
            addUsers_addBtn.Name = "addUsers_addBtn";
            addUsers_addBtn.Size = new Size(80, 58);
            addUsers_addBtn.TabIndex = 9;
            addUsers_addBtn.Text = "Add";
            addUsers_addBtn.UseVisualStyleBackColor = false;
            addUsers_addBtn.Click += addUsers_addBtn_Click;
            // 
            // addUsers_clearBtn
            // 
            addUsers_clearBtn.BackColor = Color.Violet;
            addUsers_clearBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(95, 61, 204);
            addUsers_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 61, 204);
            addUsers_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 61, 204);
            addUsers_clearBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUsers_clearBtn.Location = new Point(161, 393);
            addUsers_clearBtn.Name = "addUsers_clearBtn";
            addUsers_clearBtn.Size = new Size(80, 58);
            addUsers_clearBtn.TabIndex = 8;
            addUsers_clearBtn.Text = " Clear";
            addUsers_clearBtn.UseVisualStyleBackColor = false;
            addUsers_clearBtn.Click += addUsers_clearBtn_Click;
            // 
            // addUsers_removeBtn
            // 
            addUsers_removeBtn.BackColor = Color.Violet;
            addUsers_removeBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(95, 61, 204);
            addUsers_removeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 61, 204);
            addUsers_removeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 61, 204);
            addUsers_removeBtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUsers_removeBtn.Location = new Point(33, 393);
            addUsers_removeBtn.Name = "addUsers_removeBtn";
            addUsers_removeBtn.Size = new Size(80, 58);
            addUsers_removeBtn.TabIndex = 7;
            addUsers_removeBtn.Text = "Remove";
            addUsers_removeBtn.UseVisualStyleBackColor = false;
            addUsers_removeBtn.Click += addUsers_removeBtn_Click;
            // 
            // addUsers_updateBtn
            // 
            addUsers_updateBtn.BackColor = Color.Violet;
            addUsers_updateBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(95, 61, 204);
            addUsers_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 61, 204);
            addUsers_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 61, 204);
            addUsers_updateBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUsers_updateBtn.Location = new Point(161, 301);
            addUsers_updateBtn.Name = "addUsers_updateBtn";
            addUsers_updateBtn.Size = new Size(80, 58);
            addUsers_updateBtn.TabIndex = 6;
            addUsers_updateBtn.Text = " Update";
            addUsers_updateBtn.UseVisualStyleBackColor = false;
            addUsers_updateBtn.Click += addUsers_updateBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 210);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 4;
            label3.Text = "Role";
            // 
            // addUsers_role
            // 
            addUsers_role.FormattingEnabled = true;
            addUsers_role.Items.AddRange(new object[] { "admin", "cashier" });
            addUsers_role.Location = new Point(23, 233);
            addUsers_role.Name = "addUsers_role";
            addUsers_role.Size = new Size(227, 23);
            addUsers_role.TabIndex = 0;
            // 
            // addUsers_password
            // 
            addUsers_password.Location = new Point(23, 176);
            addUsers_password.Name = "addUsers_password";
            addUsers_password.Size = new Size(227, 23);
            addUsers_password.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 153);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // addUsers_username
            // 
            addUsers_username.Location = new Point(23, 114);
            addUsers_username.Name = "addUsers_username";
            addUsers_username.Size = new Size(227, 23);
            addUsers_username.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 91);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // AdminAddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            Controls.Add(guna2Panel2);
            Controls.Add(guna2Panel1);
            Name = "AdminAddUser";
            Size = new Size(907, 614);
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private DataGridView dataGridView1;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Button addUsers_clearBtn;
        private Button addUsers_removeBtn;
        private Button addUsers_updateBtn;
        private Label label3;
        private ComboBox addUsers_role;
        private TextBox addUsers_password;
        private Label label2;
        private TextBox addUsers_username;
        private Label label1;
        private Button addUsers_addBtn;
    }
}
