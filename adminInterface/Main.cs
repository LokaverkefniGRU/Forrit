using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Mail;


namespace adminInterface
{
    public partial class Main : Form
    {
        DatabaseMain database = new DatabaseMain();
        Class cs = new Class();
        public Main()
        {
            InitializeComponent();
            try
            {
                database.TengingVidGagnagrunn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string nafn = null;
                string[] nafnid = null;
                nafn = listBox1.SelectedItem.ToString();

                char split = ':';

                nafnid = nafn.Split(split);
                tbIDUserUpdate.Text = nafnid[0];
                tbIDUserDelete.Text = nafnid[0];
                tbEmailID.Text = nafnid[0];
                tbUsernameUserUpdate.Text = nafnid[1];
                tbUsernameUserDelete.Text = nafnid[1];
                tbFullnameUserUpdate.Text = nafnid[2];
                tbFullnameUserDelete.Text = nafnid[2];
                tbEmailName.Text = nafnid[2];
                tbEmailUserUpdate.Text = nafnid[3];
                tbEmailUserDelete.Text = nafnid[3];
                tbEmailReceiver.Text = nafnid[3];
                if (nafnid[4] == 0.ToString())
                {
                    nafnid[4] = "No";
                }
                else if (nafnid[4] == 1.ToString())
                {
                    nafnid[4] = "Yes";
                }
                tbConfirmedUserUpdate.Text = nafnid[4];
                if (nafnid[5] == 0.ToString())
                {
                    nafnid[5] = "No";
                }
                else if (nafnid[5] == 1.ToString())
                {
                    nafnid[5] = "Yes";
                }
                tbChngPwUserUpdate.Text = nafnid[5];
                if (nafnid[6] == 0.ToString())
                {
                    nafnid[6] = "No";
                }
                tbRPSUserUpdate.Text = nafnid[6];
            }
        }

        private void btShowAllUsers_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> linur = new List<string>();
            try
            {
                linur = database.Show();

                foreach (string lin in linur)
                {
                    listBox1.Items.Add(lin);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string request = tbSearchUpdate.Text;

            listBox1.Items.Clear();
            List<string> linur = new List<string>();
            try
            {
                linur = database.Search(request);

                foreach (string lin in linur)
                {
                    listBox1.Items.Add(lin);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string id = tbIDUserUpdate.Text;
            string username = tbUsernameUserUpdate.Text;
            string fullname =tbFullnameUserUpdate.Text;
            string email = tbEmailUserUpdate.Text;
            string confirmed = tbConfirmedUserUpdate.Text;
            string changepassword = tbChngPwUserUpdate.Text;
            string reportstatus = tbRPSUserUpdate.Text;

            if (confirmed == "No")
            {
                confirmed = "0";
            }
            else
            {
                confirmed = "1";
            }
            if (changepassword == "No")
            {
                changepassword = "0";
            }
            else
            {
                changepassword = "1";
            }
            if (reportstatus == "No")
            {
                reportstatus = "0";
            }
            else
            {
                reportstatus = "1";
            }
            try
            {
                database.Update(id, username, fullname, email, confirmed, changepassword, reportstatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            string fullnamem = tbFullnameUserDelete.Text;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete this user?\rUser Selected: " + fullnamem, "Admin Interface", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                string id = tbIDUserDelete.Text;
                string username = tbUsernameUserDelete.Text;
                string fullname = tbFullnameUserDelete.Text;
                string email = tbEmailUserDelete.Text;

                try
                {
                    database.Delete(id, username, fullname, email);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                listBox1.Items.Clear();
                List<string> linur = new List<string>();
                try
                {
                    linur = database.Show();

                    foreach (string lin in linur)
                    {
                        listBox1.Items.Add(lin);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
            
        
        }

        


        private void btSendEmail_Click(object sender, EventArgs e)
        {
            if (cbSendToAll.Checked)
            {
                int emm = 0;
                List<string> usercount = database.AllEmailAddresses();
                for (int i = 0; i < usercount.Count; i++)
                {
                    try
                    {
                        List<string> receiver = database.AllEmailAddresses();

                        //Sending the email.
                        //Now we must create a new Smtp client to send our email.


                        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);   //smtp.gmail.com // For Gmail
                        //smtp.live.com // Windows live / Hotmail
                        //smtp.mail.yahoo.com // Yahoo
                        //smtp.aim.com // AIM
                        //my.inbox.com // Inbox


                        //Authentication.
                        //This is where the valid email account comes into play. You must have a valid email account(with password) to give our program a place to send the mail from.

                        NetworkCredential cred = new NetworkCredential("lokaverkefni.cf@gmail.com", "EddiOgAron");

                        //To send an email we must first create a new mailMessage(an email) to send.
                        MailMessage Msg = new MailMessage();

                        // Sender e-mail address.
                        Msg.From = new MailAddress("lokaverkefni.cf@gmail.com");//Nothing But Above Credentials or your credentials (*******@gmail.com)

                        // Recipient e-mail address.
                        Msg.To.Add(receiver[emm]);

                        // Assign the subject of our message.
                        Msg.Subject = tbEmailSubject.Text;

                        // Create the content(body) of our message.
                        Msg.Body = rtbEmailBody.Text;

                        // Send our account login details to the client.
                        client.Credentials = cred;

                        //Enabling SSL(Secure Sockets Layer, encyription) is reqiured by most email providers to send mail
                        client.EnableSsl = true;

                        //Confirmation After Click the Button

                        // Send our email.
                        client.Send(Msg);


                        

                        emm++;
                    }
                    catch (Exception ex)
                    {
                        // If Mail Doesnt Send Error Mesage Will Be Displayed
                        MessageBox.Show(ex.ToString());
                    }
                }
                MessageBox.Show("Emails Sent");
            }
            else
            {
                try
                {

                    //Sending the email.
                    //Now we must create a new Smtp client to send our email.

                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);   //smtp.gmail.com // For Gmail
                    //smtp.live.com // Windows live / Hotmail
                    //smtp.mail.yahoo.com // Yahoo
                    //smtp.aim.com // AIM
                    //my.inbox.com // Inbox


                    //Authentication.
                    //This is where the valid email account comes into play. You must have a valid email account(with password) to give our program a place to send the mail from.

                    NetworkCredential cred = new NetworkCredential("lokaverkefni.cf@gmail.com", "EddiOgAron");

                    //To send an email we must first create a new mailMessage(an email) to send.
                    MailMessage Msg = new MailMessage();

                    // Sender e-mail address.
                    Msg.From = new MailAddress("lokaverkefni.cf@gmail.com");//Nothing But Above Credentials or your credentials (*******@gmail.com)

                    // Recipient e-mail address.
                    Msg.To.Add(tbEmailReceiver.Text);

                    // Assign the subject of our message.
                    Msg.Subject = tbEmailSubject.Text;

                    // Create the content(body) of our message.
                    Msg.Body = rtbEmailBody.Text;

                    // Send our account login details to the client.
                    client.Credentials = cred;

                    //Enabling SSL(Secure Sockets Layer, encyription) is reqiured by most email providers to send mail
                    client.EnableSsl = true;

                    //Confirmation After Click the Button

                    // Send our email.
                    client.Send(Msg);


                    MessageBox.Show("Email Sent to: " + tbEmailReceiver.Text + "\rBody:\r" + rtbEmailBody.Text);
                }
                catch (Exception ex)
                {
                    // If Mail Doesnt Send Error Mesage Will Be Displayed
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void cbSendToAll_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbSendToAll.Checked == true)
            {
                tbEmailID.ReadOnly = true;
                tbEmailName.ReadOnly = true;
                tbEmailReceiver.ReadOnly = true;
            }
            else
            {
                tbEmailID.ReadOnly = false;
                tbEmailName.ReadOnly = false;
                tbEmailReceiver.ReadOnly = false;
            }
            
            
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            int gen = cs.NumGenerator();

            tbKeycode.Text = gen.ToString();
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }
    }
}
