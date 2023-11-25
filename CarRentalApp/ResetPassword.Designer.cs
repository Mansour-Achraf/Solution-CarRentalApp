namespace CarRentalApp
{
    partial class ResetPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBpassword = new System.Windows.Forms.TextBox();
            this.tBconfirmpassword = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm Password";
            // 
            // tBpassword
            // 
            this.tBpassword.Location = new System.Drawing.Point(129, 62);
            this.tBpassword.Name = "tBpassword";
            this.tBpassword.PasswordChar = '*';
            this.tBpassword.Size = new System.Drawing.Size(205, 22);
            this.tBpassword.TabIndex = 2;
            // 
            // tBconfirmpassword
            // 
            this.tBconfirmpassword.Location = new System.Drawing.Point(129, 203);
            this.tBconfirmpassword.Name = "tBconfirmpassword";
            this.tBconfirmpassword.PasswordChar = '*';
            this.tBconfirmpassword.Size = new System.Drawing.Size(205, 22);
            this.tBconfirmpassword.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(169, 335);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 42);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset Password";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 406);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tBconfirmpassword);
            this.Controls.Add(this.tBpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResetPassword";
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBpassword;
        private System.Windows.Forms.TextBox tBconfirmpassword;
        private System.Windows.Forms.Button btnReset;
    }
}