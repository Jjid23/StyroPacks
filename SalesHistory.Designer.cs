namespace StyroPackPro
{
    partial class SalesHistory
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            printButton = new Button();
            inventoryReportButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(95, 61, 204);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(633, 340);
            dataGridView1.TabIndex = 0;
            // 
            // printButton
            // 
            printButton.Location = new Point(577, 472);
            printButton.Name = "printButton";
            printButton.Size = new Size(75, 23);
            printButton.TabIndex = 1;
            printButton.Text = "Click";
            printButton.UseVisualStyleBackColor = true;
            // 
            // inventoryReportButton
            // 
            inventoryReportButton.Location = new Point(33, 73);
            inventoryReportButton.Name = "inventoryReportButton";
            inventoryReportButton.Size = new Size(104, 23);
            inventoryReportButton.TabIndex = 2;
            inventoryReportButton.Text = "ReportButton";
            inventoryReportButton.UseVisualStyleBackColor = true;
            // 
            // SalesHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            Controls.Add(inventoryReportButton);
            Controls.Add(printButton);
            Controls.Add(dataGridView1);
            Name = "SalesHistory";
            Size = new Size(733, 507);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button printButton;
        private Button inventoryReportButton;
    }
}
