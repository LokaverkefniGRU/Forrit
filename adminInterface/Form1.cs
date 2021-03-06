﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adminInterface
{
    public partial class Form1 : Form
    {
        LoginDatabase database = new LoginDatabase();
        Class cs = new Class();

        public Form1()
        {
            InitializeComponent();
            try
            {
                database.TengingVidLoginGagnagrunn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tenging við gagnagrunn mistókst \r" + ex);
            }
            this.ActiveControl = tbUsernameLogin;
        }

        public void btLogin_Click(object sender, EventArgs e)
        {

            string username = tbUsernameLogin.Text;
            string password = cs.Encrypt(tbPasswordLogin.Text);
  
            bool r = database.Login(username, password);
            if (r)
            {
                Main main = new Main();
                Form1 form1 = new Form1();
                main.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Login Credentials");
            }
        }

        private void btLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                {
                string username = tbUsernameLogin.Text;
                string password = cs.Encrypt(tbPasswordLogin.Text);
  
                bool r = database.Login(username, password);
                if (r)
                {
                    Main main = new Main();
                    Form1 form1 = new Form1();
                    form1.Close();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Login Credentials");
                }
            }
        }

       


        
    }
}
