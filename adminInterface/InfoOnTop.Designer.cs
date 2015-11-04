namespace adminInterface
{
    partial class InfoOnTop
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
            this.cbOnTop = new System.Windows.Forms.CheckBox();
            this.lbOnline = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbINFOConfirmed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbINFORegistered = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbINFOBanned = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbOnTop
            // 
            this.cbOnTop.AutoSize = true;
            this.cbOnTop.Checked = true;
            this.cbOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOnTop.Location = new System.Drawing.Point(12, 74);
            this.cbOnTop.Name = "cbOnTop";
            this.cbOnTop.Size = new System.Drawing.Size(62, 17);
            this.cbOnTop.TabIndex = 17;
            this.cbOnTop.Text = "On Top";
            this.cbOnTop.UseVisualStyleBackColor = true;
            this.cbOnTop.CheckedChanged += new System.EventHandler(this.cbOnTop_CheckedChanged);
            // 
            // lbOnline
            // 
            this.lbOnline.AutoSize = true;
            this.lbOnline.ForeColor = System.Drawing.Color.Lime;
            this.lbOnline.Location = new System.Drawing.Point(71, 36);
            this.lbOnline.Name = "lbOnline";
            this.lbOnline.Size = new System.Drawing.Size(13, 13);
            this.lbOnline.TabIndex = 16;
            this.lbOnline.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Online:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Users Confirmed:";
            // 
            // tbINFOConfirmed
            // 
            this.tbINFOConfirmed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbINFOConfirmed.Location = new System.Drawing.Point(221, 48);
            this.tbINFOConfirmed.Margin = new System.Windows.Forms.Padding(7);
            this.tbINFOConfirmed.Name = "tbINFOConfirmed";
            this.tbINFOConfirmed.Size = new System.Drawing.Size(100, 13);
            this.tbINFOConfirmed.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Users Registered:";
            // 
            // tbINFORegistered
            // 
            this.tbINFORegistered.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbINFORegistered.Location = new System.Drawing.Point(221, 21);
            this.tbINFORegistered.Margin = new System.Windows.Forms.Padding(7);
            this.tbINFORegistered.Name = "tbINFORegistered";
            this.tbINFORegistered.Size = new System.Drawing.Size(100, 13);
            this.tbINFORegistered.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Users Banned:";
            // 
            // tbINFOBanned
            // 
            this.tbINFOBanned.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbINFOBanned.Location = new System.Drawing.Point(221, 75);
            this.tbINFOBanned.Margin = new System.Windows.Forms.Padding(7);
            this.tbINFOBanned.Name = "tbINFOBanned";
            this.tbINFOBanned.Size = new System.Drawing.Size(100, 13);
            this.tbINFOBanned.TabIndex = 9;
            // 
            // InfoOnTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(337, 104);
            this.Controls.Add(this.cbOnTop);
            this.Controls.Add(this.lbOnline);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbINFOConfirmed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbINFORegistered);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbINFOBanned);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoOnTop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info Panel";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InfoOnTop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbOnTop;
        private System.Windows.Forms.Label lbOnline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbINFOConfirmed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbINFORegistered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbINFOBanned;
    }
}