namespace StyroPackPro
{
    partial class CashierOrder
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrder));
            panel1 = new Panel();
            dataGridView3 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            cashierOrder_price = new Label();
            cashierOrder_prodName = new Label();
            cashierOrder_prodID = new ComboBox();
            cashierOrder_clearBtn = new Button();
            cashierOrder_removeBtn = new Button();
            cashierOrder_addBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            cashierOrder_qty = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            cashierOrder_change = new Label();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            cashierOrder_receipt = new Button();
            label9 = new Label();
            cashierOrder_amount = new TextBox();
            label8 = new Label();
            cashierOrder_totalPrice = new Label();
            cashierOrder_payOrders = new Button();
            label2 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrder_qty).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(dataGridView3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(19, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(623, 287);
            panel1.TabIndex = 0;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(95, 61, 204);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView3.Location = new Point(12, 56);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.Size = new Size(596, 218);
            dataGridView3.TabIndex = 24;
            dataGridView3.CellClick += dataGridView3_CellClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(178, 24);
            label1.TabIndex = 0;
            label1.Text = "Avaiable Products";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(cashierOrder_price);
            panel2.Controls.Add(cashierOrder_prodName);
            panel2.Controls.Add(cashierOrder_prodID);
            panel2.Controls.Add(cashierOrder_clearBtn);
            panel2.Controls.Add(cashierOrder_removeBtn);
            panel2.Controls.Add(cashierOrder_addBtn);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cashierOrder_qty);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(19, 315);
            panel2.Name = "panel2";
            panel2.Size = new Size(623, 319);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 17);
            label7.Name = "label7";
            label7.Size = new Size(170, 24);
            label7.TabIndex = 27;
            label7.Text = "Select Your Orders";
            // 
            // cashierOrder_price
            // 
            cashierOrder_price.AutoSize = true;
            cashierOrder_price.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrder_price.Location = new Point(169, 156);
            cashierOrder_price.Name = "cashierOrder_price";
            cashierOrder_price.Size = new Size(99, 25);
            cashierOrder_price.TabIndex = 26;
            cashierOrder_price.Text = "Category:";
            // 
            // cashierOrder_prodName
            // 
            cashierOrder_prodName.AutoSize = true;
            cashierOrder_prodName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrder_prodName.Location = new Point(169, 115);
            cashierOrder_prodName.Name = "cashierOrder_prodName";
            cashierOrder_prodName.Size = new Size(99, 25);
            cashierOrder_prodName.TabIndex = 25;
            cashierOrder_prodName.Text = "Category:";
            // 
            // cashierOrder_prodID
            // 
            cashierOrder_prodID.FormattingEnabled = true;
            cashierOrder_prodID.Location = new Point(132, 67);
            cashierOrder_prodID.Name = "cashierOrder_prodID";
            cashierOrder_prodID.Size = new Size(144, 23);
            cashierOrder_prodID.TabIndex = 24;
            cashierOrder_prodID.SelectedIndexChanged += cashierOrder_prodID_SelectedIndexChanged;
            // 
            // cashierOrder_clearBtn
            // 
            cashierOrder_clearBtn.BackColor = Color.MediumOrchid;
            cashierOrder_clearBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrder_clearBtn.Location = new Point(291, 244);
            cashierOrder_clearBtn.Name = "cashierOrder_clearBtn";
            cashierOrder_clearBtn.Size = new Size(115, 48);
            cashierOrder_clearBtn.TabIndex = 23;
            cashierOrder_clearBtn.Text = "Clear";
            cashierOrder_clearBtn.UseVisualStyleBackColor = false;
            cashierOrder_clearBtn.Click += cashierOrder_clearBtn_Click;
            // 
            // cashierOrder_removeBtn
            // 
            cashierOrder_removeBtn.BackColor = Color.MediumOrchid;
            cashierOrder_removeBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrder_removeBtn.Location = new Point(148, 244);
            cashierOrder_removeBtn.Name = "cashierOrder_removeBtn";
            cashierOrder_removeBtn.Size = new Size(120, 48);
            cashierOrder_removeBtn.TabIndex = 22;
            cashierOrder_removeBtn.Text = "Remove";
            cashierOrder_removeBtn.UseVisualStyleBackColor = false;
            cashierOrder_removeBtn.Click += cashierOrder_removeBtn_Click;
            // 
            // cashierOrder_addBtn
            // 
            cashierOrder_addBtn.BackColor = Color.MediumOrchid;
            cashierOrder_addBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrder_addBtn.Location = new Point(14, 244);
            cashierOrder_addBtn.Name = "cashierOrder_addBtn";
            cashierOrder_addBtn.Size = new Size(112, 48);
            cashierOrder_addBtn.TabIndex = 17;
            cashierOrder_addBtn.Text = "Add";
            cashierOrder_addBtn.UseVisualStyleBackColor = false;
            cashierOrder_addBtn.Click += cashierOrder_addBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(92, 156);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 5;
            label6.Text = "Price:  ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 115);
            label5.Name = "label5";
            label5.Size = new Size(151, 25);
            label5.TabIndex = 4;
            label5.Text = "Product Name: ";
            // 
            // cashierOrder_qty
            // 
            cashierOrder_qty.Location = new Point(443, 68);
            cashierOrder_qty.Name = "cashierOrder_qty";
            cashierOrder_qty.Size = new Size(120, 23);
            cashierOrder_qty.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(338, 65);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 2;
            label4.Text = "Quantity: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 0;
            label3.Text = "Product ID:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(cashierOrder_change);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(cashierOrder_receipt);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(cashierOrder_amount);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(cashierOrder_totalPrice);
            panel3.Controls.Add(cashierOrder_payOrders);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(648, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(273, 612);
            panel3.TabIndex = 1;
            // 
            // cashierOrder_change
            // 
            cashierOrder_change.AutoSize = true;
            cashierOrder_change.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrder_change.Location = new Point(107, 417);
            cashierOrder_change.Name = "cashierOrder_change";
            cashierOrder_change.Size = new Size(50, 25);
            cashierOrder_change.TabIndex = 28;
            cashierOrder_change.Text = "0.00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(21, 334);
            label10.Name = "label10";
            label10.Size = new Size(150, 25);
            label10.TabIndex = 27;
            label10.Text = "Total Price (₱) : ";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(95, 61, 204);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(14, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(246, 263);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // cashierOrder_receipt
            // 
            cashierOrder_receipt.BackColor = Color.MediumOrchid;
            cashierOrder_receipt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrder_receipt.Location = new Point(21, 537);
            cashierOrder_receipt.Name = "cashierOrder_receipt";
            cashierOrder_receipt.Size = new Size(217, 36);
            cashierOrder_receipt.TabIndex = 26;
            cashierOrder_receipt.Text = "Receipt";
            cashierOrder_receipt.UseVisualStyleBackColor = false;
            cashierOrder_receipt.Click += cashierOrder_receipt_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 417);
            label9.Name = "label9";
            label9.Size = new Size(89, 25);
            label9.TabIndex = 25;
            label9.Text = "Change: ";
            // 
            // cashierOrder_amount
            // 
            cashierOrder_amount.Location = new Point(107, 373);
            cashierOrder_amount.Name = "cashierOrder_amount";
            cashierOrder_amount.Size = new Size(143, 23);
            cashierOrder_amount.TabIndex = 24;
            cashierOrder_amount.KeyDown += cashierOrder_amount_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 371);
            label8.Name = "label8";
            label8.Size = new Size(95, 25);
            label8.TabIndex = 24;
            label8.Text = "Amount: ";
            // 
            // cashierOrder_totalPrice
            // 
            cashierOrder_totalPrice.AutoSize = true;
            cashierOrder_totalPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrder_totalPrice.Location = new Point(177, 334);
            cashierOrder_totalPrice.Name = "cashierOrder_totalPrice";
            cashierOrder_totalPrice.Size = new Size(23, 25);
            cashierOrder_totalPrice.TabIndex = 24;
            cashierOrder_totalPrice.Text = "0";
            // 
            // cashierOrder_payOrders
            // 
            cashierOrder_payOrders.BackColor = Color.MediumOrchid;
            cashierOrder_payOrders.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrder_payOrders.Location = new Point(21, 467);
            cashierOrder_payOrders.Name = "cashierOrder_payOrders";
            cashierOrder_payOrders.Size = new Size(217, 36);
            cashierOrder_payOrders.TabIndex = 24;
            cashierOrder_payOrders.Text = "Pay Orders";
            cashierOrder_payOrders.UseVisualStyleBackColor = false;
            cashierOrder_payOrders.Click += cashierOrder_payOrders_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 22);
            label2.Name = "label2";
            label2.Size = new Size(103, 22);
            label2.TabIndex = 2;
            label2.Text = "All Orders";
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // CashierOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(95, 61, 204);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CashierOrder";
            Size = new Size(931, 648);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrder_qty).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label5;
        private NumericUpDown cashierOrder_qty;
        private Label label4;
        private Label label3;
        private Button cashierOrder_addBtn;
        private Button cashierOrder_removeBtn;
        private Button cashierOrder_clearBtn;
        private Button cashierOrder_receipt;
        private Label label9;
        private TextBox cashierOrder_amount;
        private Label label8;
        private Label cashierOrder_totalPrice;
        private Button cashierOrder_payOrders;
        private DataGridView dataGridView3;
        private Label cashierOrder_prodName;
        private ComboBox cashierOrder_prodID;
        private Label cashierOrder_price;
        private Label label7;
        private DataGridView dataGridView1;
        private Label label10;
        private Label cashierOrder_change;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
