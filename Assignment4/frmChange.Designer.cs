namespace Assignment4
{
    partial class frmChange
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtNewPass = new System.Windows.Forms.MaskedTextBox();
            this.txtReNewPass = new System.Windows.Forms.MaskedTextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(246, 316);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(246, 99);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(266, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(246, 158);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(266, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(246, 212);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(266, 22);
            this.txtNewPass.TabIndex = 3;
            // 
            // txtReNewPass
            // 
            this.txtReNewPass.Location = new System.Drawing.Point(246, 260);
            this.txtReNewPass.Name = "txtReNewPass";
            this.txtReNewPass.PasswordChar = '*';
            this.txtReNewPass.Size = new System.Drawing.Size(266, 22);
            this.txtReNewPass.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(341, 316);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(437, 315);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtReNewPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmChange";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.MaskedTextBox txtNewPass;
        private System.Windows.Forms.MaskedTextBox txtReNewPass;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}