namespace Assignment4
{
    partial class frmMaintainBooks
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnFirstRow = new System.Windows.Forms.Button();
            this.btnPreviousRow = new System.Windows.Forms.Button();
            this.btnNextRow = new System.Windows.Forms.Button();
            this.btnLastRow = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(12, 203);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(978, 291);
            this.dgvBooks.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(227, 62);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(295, 22);
            this.txtID.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(227, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(295, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(227, 118);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(295, 22);
            this.txtPrice.TabIndex = 3;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(214, 160);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Create";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(323, 160);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(447, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 516);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(295, 22);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // txtCount
            // 
            this.txtCount.AutoSize = true;
            this.txtCount.Location = new System.Drawing.Point(313, 520);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(44, 17);
            this.txtCount.TabIndex = 2;
            this.txtCount.Text = "Sum: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(227, 974);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(295, 22);
            this.textBox2.TabIndex = 3;
            // 
            // btnFirstRow
            // 
            this.btnFirstRow.Location = new System.Drawing.Point(297, 564);
            this.btnFirstRow.Name = "btnFirstRow";
            this.btnFirstRow.Size = new System.Drawing.Size(75, 23);
            this.btnFirstRow.TabIndex = 5;
            this.btnFirstRow.Text = "<<";
            this.btnFirstRow.UseVisualStyleBackColor = true;
            this.btnFirstRow.Click += new System.EventHandler(this.btnFirstRow_Click);
            // 
            // btnPreviousRow
            // 
            this.btnPreviousRow.Location = new System.Drawing.Point(400, 564);
            this.btnPreviousRow.Name = "btnPreviousRow";
            this.btnPreviousRow.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousRow.TabIndex = 5;
            this.btnPreviousRow.Text = "<";
            this.btnPreviousRow.UseVisualStyleBackColor = true;
            this.btnPreviousRow.Click += new System.EventHandler(this.btnPreviousRow_Click);
            // 
            // btnNextRow
            // 
            this.btnNextRow.Location = new System.Drawing.Point(499, 564);
            this.btnNextRow.Name = "btnNextRow";
            this.btnNextRow.Size = new System.Drawing.Size(75, 23);
            this.btnNextRow.TabIndex = 5;
            this.btnNextRow.Text = ">";
            this.btnNextRow.UseVisualStyleBackColor = true;
            this.btnNextRow.Click += new System.EventHandler(this.btnNextRow_Click);
            // 
            // btnLastRow
            // 
            this.btnLastRow.Location = new System.Drawing.Point(600, 564);
            this.btnLastRow.Name = "btnLastRow";
            this.btnLastRow.Size = new System.Drawing.Size(75, 23);
            this.btnLastRow.TabIndex = 5;
            this.btnLastRow.Text = ">>";
            this.btnLastRow.UseVisualStyleBackColor = true;
            this.btnLastRow.Click += new System.EventHandler(this.btnLastRow_Click);
            // 
            // frmMaintainBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 599);
            this.Controls.Add(this.btnLastRow);
            this.Controls.Add(this.btnNextRow);
            this.Controls.Add(this.btnPreviousRow);
            this.Controls.Add(this.btnFirstRow);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMaintainBooks";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMaintainBooks_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label txtCount;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnFirstRow;
        private System.Windows.Forms.Button btnPreviousRow;
        private System.Windows.Forms.Button btnNextRow;
        private System.Windows.Forms.Button btnLastRow;
    }
}