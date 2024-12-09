namespace StyroPackPro
{
    partial class SalesForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            refreshH = new Button();
            SPPtable = new DataGridView();
            searchH = new TextBox();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            AStable = new DataGridView();
            refreshA = new Button();
            label5 = new Label();
            searchA = new TextBox();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SPPtable).BeginInit();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AStable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 0;
            label1.Text = "Sales Per Person";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(95, 61, 204);
            guna2Panel1.Controls.Add(refreshH);
            guna2Panel1.Controls.Add(SPPtable);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(searchH);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(16, 17);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(417, 614);
            guna2Panel1.TabIndex = 11;
            // 
            // refreshH
            // 
            refreshH.BackColor = Color.Violet;
            refreshH.FlatAppearance.CheckedBackColor = Color.FromArgb(95, 61, 204);
            refreshH.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 61, 204);
            refreshH.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 61, 204);
            refreshH.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshH.Location = new Point(255, 58);
            refreshH.Name = "refreshH";
            refreshH.Size = new Size(80, 33);
            refreshH.TabIndex = 10;
            refreshH.Text = "Refresh";
            refreshH.UseVisualStyleBackColor = false;
            // 
            // SPPtable
            // 
            SPPtable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SPPtable.Location = new Point(12, 103);
            SPPtable.Name = "SPPtable";
            SPPtable.Size = new Size(389, 494);
            SPPtable.TabIndex = 8;
            // 
            // searchH
            // 
            searchH.Location = new Point(12, 65);
            searchH.Name = "searchH";
            searchH.Size = new Size(227, 23);
            searchH.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.FromArgb(95, 61, 204);
            guna2Panel2.Controls.Add(AStable);
            guna2Panel2.Controls.Add(refreshA);
            guna2Panel2.Controls.Add(label5);
            guna2Panel2.Controls.Add(searchA);
            guna2Panel2.CustomizableEdges = customizableEdges3;
            guna2Panel2.Location = new Point(439, 17);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel2.Size = new Size(451, 614);
            guna2Panel2.TabIndex = 12;
            // 
            // AStable
            // 
            AStable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AStable.Location = new Point(12, 103);
            AStable.Name = "AStable";
            AStable.Size = new Size(422, 494);
            AStable.TabIndex = 9;
            AStable.CellContentClick += AStable_CellContentClick;
            // 
            // refreshA
            // 
            refreshA.BackColor = Color.Violet;
            refreshA.FlatAppearance.CheckedBackColor = Color.FromArgb(95, 61, 204);
            refreshA.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 61, 204);
            refreshA.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 61, 204);
            refreshA.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshA.Location = new Point(258, 58);
            refreshA.Name = "refreshA";
            refreshA.Size = new Size(80, 33);
            refreshA.TabIndex = 8;
            refreshA.Text = "Refresh";
            refreshA.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(12, 22);
            label5.Name = "label5";
            label5.Size = new Size(134, 21);
            label5.TabIndex = 0;
            label5.Text = "Sales Per Person";
            // 
            // searchA
            // 
            searchA.Location = new Point(12, 65);
            searchA.Name = "searchA";
            searchA.Size = new Size(227, 23);
            searchA.TabIndex = 0;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2Panel2);
            Name = "SalesForm";
            Size = new Size(907, 648);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SPPtable).EndInit();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AStable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Button refreshH;
        private DataGridView SPPtable;
        private TextBox searchH;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private DataGridView AStable;
        private Button refreshA;
        private Label label5;
        private TextBox searchA;
    }
}
