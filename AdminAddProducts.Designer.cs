namespace StyroPackPro
{
    partial class AdminAddProducts
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            DataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            addProducts_removeBtn = new Button();
            addProducts_status = new ComboBox();
            addProducts_clearBtn = new Button();
            addProducts_updateBtn = new Button();
            addProducts_addBtn = new Button();
            addProducts_ImportBtn = new Button();
            panel3 = new Panel();
            addProducts_imageView = new PictureBox();
            label6 = new Label();
            addProducts_stock = new TextBox();
            label5 = new Label();
            addProducts_price = new TextBox();
            label4 = new Label();
            addProducts_prodName = new TextBox();
            label3 = new Label();
            addProducts_prodID = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addProducts_imageView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(DataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(19, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 330);
            panel1.TabIndex = 0;
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.AllowUserToDeleteRows = false;
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(95, 61, 204);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            DataGridView1.Location = new Point(14, 44);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.ReadOnly = true;
            DataGridView1.RowHeadersVisible = false;
            DataGridView1.Size = new Size(840, 261);
            DataGridView1.TabIndex = 11;
            DataGridView1.CellClick += DataGridView1_CellClick;
            DataGridView1.CellContentClick += DataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 21);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 2;
            label1.Text = "All Products";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(addProducts_removeBtn);
            panel2.Controls.Add(addProducts_status);
            panel2.Controls.Add(addProducts_clearBtn);
            panel2.Controls.Add(addProducts_updateBtn);
            panel2.Controls.Add(addProducts_addBtn);
            panel2.Controls.Add(addProducts_ImportBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addProducts_stock);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(addProducts_price);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addProducts_prodName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(addProducts_prodID);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(19, 374);
            panel2.Name = "panel2";
            panel2.Size = new Size(866, 257);
            panel2.TabIndex = 1;
            // 
            // addProducts_removeBtn
            // 
            addProducts_removeBtn.BackColor = Color.MediumOrchid;
            addProducts_removeBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProducts_removeBtn.Location = new Point(374, 193);
            addProducts_removeBtn.Name = "addProducts_removeBtn";
            addProducts_removeBtn.Size = new Size(105, 36);
            addProducts_removeBtn.TabIndex = 21;
            addProducts_removeBtn.Text = "Remove";
            addProducts_removeBtn.UseVisualStyleBackColor = false;
            addProducts_removeBtn.Click += addProducts_removeBtn_Click_1;
            // 
            // addProducts_status
            // 
            addProducts_status.FormattingEnabled = true;
            addProducts_status.Items.AddRange(new object[] { "Available", "Not Available" });
            addProducts_status.Location = new Point(440, 117);
            addProducts_status.Name = "addProducts_status";
            addProducts_status.Size = new Size(199, 23);
            addProducts_status.TabIndex = 20;
            // 
            // addProducts_clearBtn
            // 
            addProducts_clearBtn.BackColor = Color.MediumOrchid;
            addProducts_clearBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProducts_clearBtn.Location = new Point(524, 193);
            addProducts_clearBtn.Name = "addProducts_clearBtn";
            addProducts_clearBtn.Size = new Size(105, 36);
            addProducts_clearBtn.TabIndex = 19;
            addProducts_clearBtn.Text = "Clear";
            addProducts_clearBtn.UseVisualStyleBackColor = false;
            addProducts_clearBtn.Click += addProducts_clearBtn_Click;
            // 
            // addProducts_updateBtn
            // 
            addProducts_updateBtn.BackColor = Color.MediumOrchid;
            addProducts_updateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProducts_updateBtn.Location = new Point(233, 193);
            addProducts_updateBtn.Name = "addProducts_updateBtn";
            addProducts_updateBtn.Size = new Size(105, 36);
            addProducts_updateBtn.TabIndex = 17;
            addProducts_updateBtn.Text = "Update";
            addProducts_updateBtn.UseVisualStyleBackColor = false;
            addProducts_updateBtn.Click += addProducts_updateBtn_Click;
            // 
            // addProducts_addBtn
            // 
            addProducts_addBtn.BackColor = Color.MediumOrchid;
            addProducts_addBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProducts_addBtn.Location = new Point(77, 193);
            addProducts_addBtn.Name = "addProducts_addBtn";
            addProducts_addBtn.Size = new Size(105, 36);
            addProducts_addBtn.TabIndex = 16;
            addProducts_addBtn.Text = "Add";
            addProducts_addBtn.UseVisualStyleBackColor = false;
            addProducts_addBtn.Click += addProducts_addBtn_Click;
            // 
            // addProducts_ImportBtn
            // 
            addProducts_ImportBtn.BackColor = Color.MediumOrchid;
            addProducts_ImportBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProducts_ImportBtn.Location = new Point(737, 146);
            addProducts_ImportBtn.Name = "addProducts_ImportBtn";
            addProducts_ImportBtn.Size = new Size(105, 28);
            addProducts_ImportBtn.TabIndex = 15;
            addProducts_ImportBtn.Text = "Import Image";
            addProducts_ImportBtn.UseVisualStyleBackColor = false;
            addProducts_ImportBtn.Click += addProducts_ImportBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Controls.Add(addProducts_imageView);
            panel3.Location = new Point(737, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(105, 112);
            panel3.TabIndex = 14;
            // 
            // addProducts_imageView
            // 
            addProducts_imageView.Location = new Point(0, 0);
            addProducts_imageView.Name = "addProducts_imageView";
            addProducts_imageView.Size = new Size(105, 112);
            addProducts_imageView.SizeMode = PictureBoxSizeMode.StretchImage;
            addProducts_imageView.TabIndex = 0;
            addProducts_imageView.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(384, 112);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 12;
            label6.Text = "Status:";
            // 
            // addProducts_stock
            // 
            addProducts_stock.Location = new Point(440, 72);
            addProducts_stock.Name = "addProducts_stock";
            addProducts_stock.Size = new Size(199, 23);
            addProducts_stock.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(384, 72);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 10;
            label5.Text = "Stock: ";
            // 
            // addProducts_price
            // 
            addProducts_price.Location = new Point(440, 32);
            addProducts_price.Name = "addProducts_price";
            addProducts_price.Size = new Size(199, 23);
            addProducts_price.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(384, 31);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 8;
            label4.Text = "Price :";
            // 
            // addProducts_prodName
            // 
            addProducts_prodName.Location = new Point(149, 71);
            addProducts_prodName.Name = "addProducts_prodName";
            addProducts_prodName.Size = new Size(189, 23);
            addProducts_prodName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(29, 71);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 6;
            label3.Text = "Product Name:";
            // 
            // addProducts_prodID
            // 
            addProducts_prodID.Location = new Point(149, 30);
            addProducts_prodID.Name = "addProducts_prodID";
            addProducts_prodID.Size = new Size(189, 23);
            addProducts_prodID.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(54, 30);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 4;
            label2.Text = "Product ID:";
            // 
            // AdminAddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(95, 61, 204);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAddProducts";
            Size = new Size(907, 648);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)addProducts_imageView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label6;
        private TextBox addProducts_stock;
        private Label label5;
        private TextBox addProducts_price;
        private Label label4;
        private TextBox addProducts_prodName;
        private Label label3;
        private TextBox addProducts_prodID;
        private Button addProducts_ImportBtn;
        private Panel panel3;
        private PictureBox addProducts_imageView;
        private Button addProducts_clearBtn;
        private Button addProducts_updateBtn;
        private Button addProducts_addBtn;
        private ComboBox addProducts_status;
        private DataGridView DataGridView1;
        private Button addProducts_removeBtn;
    }
}
