namespace adminInterface
{
    partial class Form1
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
            this.tbUsernameLogin = new System.Windows.Forms.TextBox();
            this.tbPasswordLogin = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // tbUsernameLogin
            // 
            this.tbUsernameLogin.Location = new System.Drawing.Point(89, 23);
            this.tbUsernameLogin.Name = "tbUsernameLogin";
            this.tbUsernameLogin.Size = new System.Drawing.Size(156, 20);
            this.tbUsernameLogin.TabIndex = 2;
            // 
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.Location = new System.Drawing.Point(89, 62);
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.PasswordChar = '*';
            this.tbPasswordLogin.Size = new System.Drawing.Size(156, 20);
            this.tbPasswordLogin.TabIndex = 3;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(102, 103);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            this.btLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btLogin_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 143);
            this.Controls.Add(this.tbUsernameLogin);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPasswordLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btLogin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsernameLogin;
        private System.Windows.Forms.TextBox tbPasswordLogin;
        private System.Windows.Forms.Button btLogin;
    }
}

