namespace adminInterface
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btSearchUpdate = new System.Windows.Forms.Button();
            this.tbSearchUpdate = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btShowAllUserUpdate = new System.Windows.Forms.Button();
            this.tabPost = new System.Windows.Forms.TabPage();
            this.btShowAllPosts = new System.Windows.Forms.Button();
            this.rtbPostBody = new System.Windows.Forms.RichTextBox();
            this.tabEmail = new System.Windows.Forms.TabPage();
            this.tbEmailSubject = new System.Windows.Forms.TextBox();
            this.rtbEmailBody = new System.Windows.Forms.RichTextBox();
            this.tbEmailID = new System.Windows.Forms.TextBox();
            this.tbEmailName = new System.Windows.Forms.TextBox();
            this.tbEmailReceiver = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbSendToAll = new System.Windows.Forms.CheckBox();
            this.btSendEmail = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btBan = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tbWarningCountUserReport = new System.Windows.Forms.TextBox();
            this.tbBanStatusUserReport = new System.Windows.Forms.TextBox();
            this.tbReportStatusUserReport = new System.Windows.Forms.TextBox();
            this.tbIDUserReport = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btShowReportedUsers = new System.Windows.Forms.Button();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.btDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbEmailUserDelete = new System.Windows.Forms.TextBox();
            this.tbFullnameUserDelete = new System.Windows.Forms.TextBox();
            this.tbUsernameUserDelete = new System.Windows.Forms.TextBox();
            this.tbIDUserDelete = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabUpdate = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRPSUserUpdate = new System.Windows.Forms.TextBox();
            this.tbChngPwUserUpdate = new System.Windows.Forms.TextBox();
            this.tbConfirmedUserUpdate = new System.Windows.Forms.TextBox();
            this.tbEmailUserUpdate = new System.Windows.Forms.TextBox();
            this.tbFullnameUserUpdate = new System.Windows.Forms.TextBox();
            this.tbUsernameUserUpdate = new System.Windows.Forms.TextBox();
            this.tbIDUserUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabReport = new System.Windows.Forms.TabControl();
            this.btInfo = new System.Windows.Forms.Button();
            this.tbPostDate = new System.Windows.Forms.TextBox();
            this.tbPostID = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tbPosterID = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tabPost.SuspendLayout();
            this.tabEmail.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.tabUpdate.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSearchUpdate
            // 
            this.btSearchUpdate.Location = new System.Drawing.Point(185, 170);
            this.btSearchUpdate.Name = "btSearchUpdate";
            this.btSearchUpdate.Size = new System.Drawing.Size(96, 21);
            this.btSearchUpdate.TabIndex = 19;
            this.btSearchUpdate.Text = "Search";
            this.btSearchUpdate.UseVisualStyleBackColor = true;
            this.btSearchUpdate.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbSearchUpdate
            // 
            this.tbSearchUpdate.Location = new System.Drawing.Point(287, 171);
            this.tbSearchUpdate.Name = "tbSearchUpdate";
            this.tbSearchUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbSearchUpdate.TabIndex = 18;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(2, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(622, 160);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btShowAllUserUpdate
            // 
            this.btShowAllUserUpdate.Location = new System.Drawing.Point(517, 166);
            this.btShowAllUserUpdate.Name = "btShowAllUserUpdate";
            this.btShowAllUserUpdate.Size = new System.Drawing.Size(96, 21);
            this.btShowAllUserUpdate.TabIndex = 15;
            this.btShowAllUserUpdate.Text = "Show All Users";
            this.btShowAllUserUpdate.UseVisualStyleBackColor = true;
            this.btShowAllUserUpdate.Click += new System.EventHandler(this.btShowAllUsers_Click);
            // 
            // tabPost
            // 
            this.tabPost.Controls.Add(this.tbPosterID);
            this.tabPost.Controls.Add(this.label25);
            this.tabPost.Controls.Add(this.tbPostDate);
            this.tabPost.Controls.Add(this.tbPostID);
            this.tabPost.Controls.Add(this.label23);
            this.tabPost.Controls.Add(this.label24);
            this.tabPost.Controls.Add(this.rtbPostBody);
            this.tabPost.Location = new System.Drawing.Point(4, 22);
            this.tabPost.Name = "tabPost";
            this.tabPost.Padding = new System.Windows.Forms.Padding(3);
            this.tabPost.Size = new System.Drawing.Size(626, 277);
            this.tabPost.TabIndex = 4;
            this.tabPost.Text = "Post Control";
            this.tabPost.UseVisualStyleBackColor = true;
            // 
            // btShowAllPosts
            // 
            this.btShowAllPosts.Location = new System.Drawing.Point(517, 166);
            this.btShowAllPosts.Name = "btShowAllPosts";
            this.btShowAllPosts.Size = new System.Drawing.Size(96, 21);
            this.btShowAllPosts.TabIndex = 16;
            this.btShowAllPosts.Text = "Show All Posts";
            this.btShowAllPosts.UseVisualStyleBackColor = true;
            this.btShowAllPosts.Click += new System.EventHandler(this.btShowAllPosts_Click);
            // 
            // rtbPostBody
            // 
            this.rtbPostBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbPostBody.Location = new System.Drawing.Point(435, 0);
            this.rtbPostBody.Name = "rtbPostBody";
            this.rtbPostBody.Size = new System.Drawing.Size(191, 261);
            this.rtbPostBody.TabIndex = 0;
            this.rtbPostBody.Text = "";
            // 
            // tabEmail
            // 
            this.tabEmail.Controls.Add(this.tbEmailSubject);
            this.tabEmail.Controls.Add(this.rtbEmailBody);
            this.tabEmail.Controls.Add(this.tbEmailID);
            this.tabEmail.Controls.Add(this.tbEmailName);
            this.tabEmail.Controls.Add(this.tbEmailReceiver);
            this.tabEmail.Controls.Add(this.label19);
            this.tabEmail.Controls.Add(this.cbSendToAll);
            this.tabEmail.Controls.Add(this.btSendEmail);
            this.tabEmail.Controls.Add(this.label8);
            this.tabEmail.Controls.Add(this.label9);
            this.tabEmail.Controls.Add(this.label10);
            this.tabEmail.Location = new System.Drawing.Point(4, 22);
            this.tabEmail.Name = "tabEmail";
            this.tabEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmail.Size = new System.Drawing.Size(626, 277);
            this.tabEmail.TabIndex = 3;
            this.tabEmail.Text = "Email";
            this.tabEmail.UseVisualStyleBackColor = true;
            // 
            // tbEmailSubject
            // 
            this.tbEmailSubject.Location = new System.Drawing.Point(260, 52);
            this.tbEmailSubject.Name = "tbEmailSubject";
            this.tbEmailSubject.Size = new System.Drawing.Size(151, 20);
            this.tbEmailSubject.TabIndex = 4;
            // 
            // rtbEmailBody
            // 
            this.rtbEmailBody.Location = new System.Drawing.Point(209, 92);
            this.rtbEmailBody.Name = "rtbEmailBody";
            this.rtbEmailBody.Size = new System.Drawing.Size(288, 91);
            this.rtbEmailBody.TabIndex = 5;
            this.rtbEmailBody.Text = "Insert your message here";
            // 
            // tbEmailID
            // 
            this.tbEmailID.Location = new System.Drawing.Point(52, 92);
            this.tbEmailID.Name = "tbEmailID";
            this.tbEmailID.Size = new System.Drawing.Size(151, 20);
            this.tbEmailID.TabIndex = 1;
            // 
            // tbEmailName
            // 
            this.tbEmailName.Location = new System.Drawing.Point(52, 127);
            this.tbEmailName.Name = "tbEmailName";
            this.tbEmailName.Size = new System.Drawing.Size(151, 20);
            this.tbEmailName.TabIndex = 2;
            // 
            // tbEmailReceiver
            // 
            this.tbEmailReceiver.Location = new System.Drawing.Point(52, 162);
            this.tbEmailReceiver.Name = "tbEmailReceiver";
            this.tbEmailReceiver.Size = new System.Drawing.Size(151, 20);
            this.tbEmailReceiver.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(211, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Subject";
            // 
            // cbSendToAll
            // 
            this.cbSendToAll.AutoSize = true;
            this.cbSendToAll.Location = new System.Drawing.Point(517, 139);
            this.cbSendToAll.Name = "cbSendToAll";
            this.cbSendToAll.Size = new System.Drawing.Size(76, 17);
            this.cbSendToAll.TabIndex = 22;
            this.cbSendToAll.Text = "Send to all";
            this.cbSendToAll.UseVisualStyleBackColor = true;
            this.cbSendToAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbSendToAll_MouseClick);
            // 
            // btSendEmail
            // 
            this.btSendEmail.Location = new System.Drawing.Point(503, 162);
            this.btSendEmail.Name = "btSendEmail";
            this.btSendEmail.Size = new System.Drawing.Size(96, 21);
            this.btSendEmail.TabIndex = 6;
            this.btSendEmail.Text = "Send Email";
            this.btSendEmail.UseVisualStyleBackColor = true;
            this.btSendEmail.Click += new System.EventHandler(this.btSendEmail_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Email";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btBan);
            this.tabPage6.Controls.Add(this.label18);
            this.tabPage6.Controls.Add(this.tbWarningCountUserReport);
            this.tabPage6.Controls.Add(this.tbBanStatusUserReport);
            this.tabPage6.Controls.Add(this.tbReportStatusUserReport);
            this.tabPage6.Controls.Add(this.tbIDUserReport);
            this.tabPage6.Controls.Add(this.label17);
            this.tabPage6.Controls.Add(this.label16);
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Controls.Add(this.btShowReportedUsers);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(626, 277);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Report Control";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btBan
            // 
            this.btBan.Location = new System.Drawing.Point(105, 200);
            this.btBan.Name = "btBan";
            this.btBan.Size = new System.Drawing.Size(96, 21);
            this.btBan.TabIndex = 40;
            this.btBan.Text = "Ban User";
            this.btBan.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "Warning Count";
            // 
            // tbWarningCountUserReport
            // 
            this.tbWarningCountUserReport.Location = new System.Drawing.Point(92, 129);
            this.tbWarningCountUserReport.Name = "tbWarningCountUserReport";
            this.tbWarningCountUserReport.Size = new System.Drawing.Size(122, 20);
            this.tbWarningCountUserReport.TabIndex = 38;
            // 
            // tbBanStatusUserReport
            // 
            this.tbBanStatusUserReport.Location = new System.Drawing.Point(92, 164);
            this.tbBanStatusUserReport.Name = "tbBanStatusUserReport";
            this.tbBanStatusUserReport.Size = new System.Drawing.Size(122, 20);
            this.tbBanStatusUserReport.TabIndex = 36;
            // 
            // tbReportStatusUserReport
            // 
            this.tbReportStatusUserReport.Location = new System.Drawing.Point(92, 94);
            this.tbReportStatusUserReport.Name = "tbReportStatusUserReport";
            this.tbReportStatusUserReport.Size = new System.Drawing.Size(122, 20);
            this.tbReportStatusUserReport.TabIndex = 34;
            // 
            // tbIDUserReport
            // 
            this.tbIDUserReport.Location = new System.Drawing.Point(92, 59);
            this.tbIDUserReport.Name = "tbIDUserReport";
            this.tbIDUserReport.Size = new System.Drawing.Size(122, 20);
            this.tbIDUserReport.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Ban Status";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Report Status";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(68, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "ID";
            // 
            // btShowReportedUsers
            // 
            this.btShowReportedUsers.Location = new System.Drawing.Point(509, 20);
            this.btShowReportedUsers.Name = "btShowReportedUsers";
            this.btShowReportedUsers.Size = new System.Drawing.Size(96, 21);
            this.btShowReportedUsers.TabIndex = 20;
            this.btShowReportedUsers.Text = "Reported Users";
            this.btShowReportedUsers.UseVisualStyleBackColor = true;
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.btDelete);
            this.tabDelete.Controls.Add(this.label11);
            this.tabDelete.Controls.Add(this.tbEmailUserDelete);
            this.tabDelete.Controls.Add(this.tbFullnameUserDelete);
            this.tabDelete.Controls.Add(this.tbUsernameUserDelete);
            this.tabDelete.Controls.Add(this.tbIDUserDelete);
            this.tabDelete.Controls.Add(this.label12);
            this.tabDelete.Controls.Add(this.label13);
            this.tabDelete.Controls.Add(this.label14);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(626, 277);
            this.tabDelete.TabIndex = 1;
            this.tabDelete.Text = "Delete";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(112, 207);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(96, 21);
            this.btDelete.TabIndex = 34;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Email";
            // 
            // tbEmailUserDelete
            // 
            this.tbEmailUserDelete.Location = new System.Drawing.Point(98, 166);
            this.tbEmailUserDelete.Name = "tbEmailUserDelete";
            this.tbEmailUserDelete.Size = new System.Drawing.Size(151, 20);
            this.tbEmailUserDelete.TabIndex = 26;
            // 
            // tbFullnameUserDelete
            // 
            this.tbFullnameUserDelete.Location = new System.Drawing.Point(98, 131);
            this.tbFullnameUserDelete.Name = "tbFullnameUserDelete";
            this.tbFullnameUserDelete.Size = new System.Drawing.Size(151, 20);
            this.tbFullnameUserDelete.TabIndex = 24;
            // 
            // tbUsernameUserDelete
            // 
            this.tbUsernameUserDelete.Location = new System.Drawing.Point(98, 96);
            this.tbUsernameUserDelete.Name = "tbUsernameUserDelete";
            this.tbUsernameUserDelete.Size = new System.Drawing.Size(151, 20);
            this.tbUsernameUserDelete.TabIndex = 22;
            // 
            // tbIDUserDelete
            // 
            this.tbIDUserDelete.Location = new System.Drawing.Point(98, 61);
            this.tbIDUserDelete.Name = "tbIDUserDelete";
            this.tbIDUserDelete.Size = new System.Drawing.Size(151, 20);
            this.tbIDUserDelete.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Fullname";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Username";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(74, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "ID";
            // 
            // tabUpdate
            // 
            this.tabUpdate.Controls.Add(this.label20);
            this.tabUpdate.Controls.Add(this.btUpdate);
            this.tabUpdate.Controls.Add(this.label7);
            this.tabUpdate.Controls.Add(this.tbRPSUserUpdate);
            this.tabUpdate.Controls.Add(this.tbChngPwUserUpdate);
            this.tabUpdate.Controls.Add(this.tbConfirmedUserUpdate);
            this.tabUpdate.Controls.Add(this.tbEmailUserUpdate);
            this.tabUpdate.Controls.Add(this.tbFullnameUserUpdate);
            this.tabUpdate.Controls.Add(this.tbUsernameUserUpdate);
            this.tabUpdate.Controls.Add(this.tbIDUserUpdate);
            this.tabUpdate.Controls.Add(this.label6);
            this.tabUpdate.Controls.Add(this.label5);
            this.tabUpdate.Controls.Add(this.label4);
            this.tabUpdate.Controls.Add(this.label3);
            this.tabUpdate.Controls.Add(this.label2);
            this.tabUpdate.Controls.Add(this.label1);
            this.tabUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabUpdate.Name = "tabUpdate";
            this.tabUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdate.Size = new System.Drawing.Size(626, 277);
            this.tabUpdate.TabIndex = 0;
            this.tabUpdate.Text = "Update";
            this.tabUpdate.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(435, 61);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Status";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(237, 201);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(96, 21);
            this.btUpdate.TabIndex = 17;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Report Status";
            // 
            // tbRPSUserUpdate
            // 
            this.tbRPSUserUpdate.Location = new System.Drawing.Point(386, 159);
            this.tbRPSUserUpdate.Name = "tbRPSUserUpdate";
            this.tbRPSUserUpdate.Size = new System.Drawing.Size(151, 20);
            this.tbRPSUserUpdate.TabIndex = 13;
            // 
            // tbChngPwUserUpdate
            // 
            this.tbChngPwUserUpdate.Location = new System.Drawing.Point(386, 124);
            this.tbChngPwUserUpdate.Name = "tbChngPwUserUpdate";
            this.tbChngPwUserUpdate.Size = new System.Drawing.Size(151, 20);
            this.tbChngPwUserUpdate.TabIndex = 11;
            // 
            // tbConfirmedUserUpdate
            // 
            this.tbConfirmedUserUpdate.Location = new System.Drawing.Point(386, 89);
            this.tbConfirmedUserUpdate.Name = "tbConfirmedUserUpdate";
            this.tbConfirmedUserUpdate.Size = new System.Drawing.Size(151, 20);
            this.tbConfirmedUserUpdate.TabIndex = 9;
            // 
            // tbEmailUserUpdate
            // 
            this.tbEmailUserUpdate.Location = new System.Drawing.Point(107, 159);
            this.tbEmailUserUpdate.Name = "tbEmailUserUpdate";
            this.tbEmailUserUpdate.Size = new System.Drawing.Size(151, 20);
            this.tbEmailUserUpdate.TabIndex = 7;
            // 
            // tbFullnameUserUpdate
            // 
            this.tbFullnameUserUpdate.Location = new System.Drawing.Point(107, 124);
            this.tbFullnameUserUpdate.Name = "tbFullnameUserUpdate";
            this.tbFullnameUserUpdate.Size = new System.Drawing.Size(151, 20);
            this.tbFullnameUserUpdate.TabIndex = 5;
            // 
            // tbUsernameUserUpdate
            // 
            this.tbUsernameUserUpdate.Location = new System.Drawing.Point(107, 89);
            this.tbUsernameUserUpdate.Name = "tbUsernameUserUpdate";
            this.tbUsernameUserUpdate.Size = new System.Drawing.Size(151, 20);
            this.tbUsernameUserUpdate.TabIndex = 3;
            // 
            // tbIDUserUpdate
            // 
            this.tbIDUserUpdate.Location = new System.Drawing.Point(107, 54);
            this.tbIDUserUpdate.Name = "tbIDUserUpdate";
            this.tbIDUserUpdate.Size = new System.Drawing.Size(151, 20);
            this.tbIDUserUpdate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Change password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirmed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fullname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.tabUpdate);
            this.tabReport.Controls.Add(this.tabDelete);
            this.tabReport.Controls.Add(this.tabPage6);
            this.tabReport.Controls.Add(this.tabEmail);
            this.tabReport.Controls.Add(this.tabPost);
            this.tabReport.Location = new System.Drawing.Point(0, 215);
            this.tabReport.Name = "tabReport";
            this.tabReport.SelectedIndex = 0;
            this.tabReport.Size = new System.Drawing.Size(634, 303);
            this.tabReport.TabIndex = 0;
            this.tabReport.SelectedIndexChanged += new System.EventHandler(this.tabReport_SelectedIndexChanged);
            // 
            // btInfo
            // 
            this.btInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btInfo.BackgroundImage")));
            this.btInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btInfo.Image = ((System.Drawing.Image)(resources.GetObject("btInfo.Image")));
            this.btInfo.Location = new System.Drawing.Point(580, 193);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(33, 31);
            this.btInfo.TabIndex = 22;
            this.btInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btInfo.UseVisualStyleBackColor = true;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // tbPostDate
            // 
            this.tbPostDate.Location = new System.Drawing.Point(247, 156);
            this.tbPostDate.Name = "tbPostDate";
            this.tbPostDate.Size = new System.Drawing.Size(151, 20);
            this.tbPostDate.TabIndex = 19;
            // 
            // tbPostID
            // 
            this.tbPostID.Location = new System.Drawing.Point(247, 84);
            this.tbPostID.Name = "tbPostID";
            this.tbPostID.Size = new System.Drawing.Size(151, 20);
            this.tbPostID.TabIndex = 17;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(211, 159);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(30, 13);
            this.label23.TabIndex = 20;
            this.label23.Text = "Date";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(199, 87);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 13);
            this.label24.TabIndex = 18;
            this.label24.Text = "Post ID";
            // 
            // tbPosterID
            // 
            this.tbPosterID.Location = new System.Drawing.Point(247, 121);
            this.tbPosterID.Name = "tbPosterID";
            this.tbPosterID.Size = new System.Drawing.Size(151, 20);
            this.tbPosterID.TabIndex = 25;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(190, 124);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(51, 13);
            this.label25.TabIndex = 26;
            this.label25.Text = "Poster ID";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 497);
            this.Controls.Add(this.btInfo);
            this.Controls.Add(this.tabReport);
            this.Controls.Add(this.btSearchUpdate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbSearchUpdate);
            this.Controls.Add(this.btShowAllUserUpdate);
            this.Controls.Add(this.btShowAllPosts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.tabPost.ResumeLayout(false);
            this.tabPost.PerformLayout();
            this.tabEmail.ResumeLayout(false);
            this.tabEmail.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabDelete.PerformLayout();
            this.tabUpdate.ResumeLayout(false);
            this.tabUpdate.PerformLayout();
            this.tabReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btShowAllUserUpdate;
        private System.Windows.Forms.Button btSearchUpdate;
        private System.Windows.Forms.TextBox tbSearchUpdate;
        private System.Windows.Forms.TabPage tabPost;
        private System.Windows.Forms.TabPage tabEmail;
        private System.Windows.Forms.TextBox tbEmailSubject;
        private System.Windows.Forms.RichTextBox rtbEmailBody;
        private System.Windows.Forms.TextBox tbEmailID;
        private System.Windows.Forms.TextBox tbEmailName;
        private System.Windows.Forms.TextBox tbEmailReceiver;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox cbSendToAll;
        private System.Windows.Forms.Button btSendEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btBan;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbWarningCountUserReport;
        private System.Windows.Forms.TextBox tbBanStatusUserReport;
        private System.Windows.Forms.TextBox tbReportStatusUserReport;
        private System.Windows.Forms.TextBox tbIDUserReport;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btShowReportedUsers;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbEmailUserDelete;
        private System.Windows.Forms.TextBox tbFullnameUserDelete;
        private System.Windows.Forms.TextBox tbUsernameUserDelete;
        private System.Windows.Forms.TextBox tbIDUserDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabUpdate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRPSUserUpdate;
        private System.Windows.Forms.TextBox tbChngPwUserUpdate;
        private System.Windows.Forms.TextBox tbConfirmedUserUpdate;
        private System.Windows.Forms.TextBox tbEmailUserUpdate;
        private System.Windows.Forms.TextBox tbFullnameUserUpdate;
        private System.Windows.Forms.TextBox tbUsernameUserUpdate;
        private System.Windows.Forms.TextBox tbIDUserUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabReport;
        private System.Windows.Forms.Button btInfo;
        private System.Windows.Forms.Button btShowAllPosts;
        private System.Windows.Forms.RichTextBox rtbPostBody;
        private System.Windows.Forms.TextBox tbPostDate;
        private System.Windows.Forms.TextBox tbPostID;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbPosterID;
        private System.Windows.Forms.Label label25;
    }
}