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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbKeyCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUsernameRegister = new System.Windows.Forms.TextBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPasswordRegister = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // tbUsernameLogin
            // 
            this.tbUsernameLogin.Location = new System.Drawing.Point(90, 22);
            this.tbUsernameLogin.Name = "tbUsernameLogin";
            this.tbUsernameLogin.Size = new System.Drawing.Size(156, 20);
            this.tbUsernameLogin.TabIndex = 2;
            // 
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.Location = new System.Drawing.Point(90, 61);
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.PasswordChar = '*';
            this.tbPasswordLogin.Size = new System.Drawing.Size(156, 20);
            this.tbPasswordLogin.TabIndex = 3;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(103, 102);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            this.btLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btLogin_KeyDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(287, 179);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbUsernameLogin);
            this.tabPage1.Controls.Add(this.btLogin);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbPasswordLogin);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(279, 153);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbKeyCode);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbUsernameRegister);
            this.tabPage2.Controls.Add(this.btRegister);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbPasswordRegister);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(279, 153);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Register";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbKeyCode
            // 
            this.tbKeyCode.Location = new System.Drawing.Point(122, 73);
            this.tbKeyCode.Name = "tbKeyCode";
            this.tbKeyCode.PasswordChar = '*';
            this.tbKeyCode.Size = new System.Drawing.Size(68, 20);
            this.tbKeyCode.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "KeyCode";
            // 
            // tbUsernameRegister
            // 
            this.tbUsernameRegister.Location = new System.Drawing.Point(88, 14);
            this.tbUsernameRegister.Name = "tbUsernameRegister";
            this.tbUsernameRegister.Size = new System.Drawing.Size(156, 20);
            this.tbUsernameRegister.TabIndex = 7;
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(102, 103);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(75, 23);
            this.btRegister.TabIndex = 9;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // tbPasswordRegister
            // 
            this.tbPasswordRegister.Location = new System.Drawing.Point(88, 40);
            this.tbPasswordRegister.Name = "tbPasswordRegister";
            this.tbPasswordRegister.PasswordChar = '*';
            this.tbPasswordRegister.Size = new System.Drawing.Size(156, 20);
            this.tbPasswordRegister.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 174);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btLogin_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsernameLogin;
        private System.Windows.Forms.TextBox tbPasswordLogin;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbKeyCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUsernameRegister;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPasswordRegister;
        private System.Windows.Forms.Label label4;
    }
}

