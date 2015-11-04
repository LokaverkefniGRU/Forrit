using System;
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
    public partial class Info : Form
    {
        DatabaseMain database = new DatabaseMain();
        Class cs = new Class();
        public Info()
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

        private void Info_Load(object sender, EventArgs e)
        {
            this.TopMost = cbOnTop.Checked;

            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval=700;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();

            List<int> Registered = database.UserCount();
            tbINFORegistered.Text = Registered.Count().ToString();

            List<int> Online = database.UserOnline();
            lbOnline.Text = Online.Count().ToString();

            List<int> Confirmed = database.UserConfirmed();
            tbINFOConfirmed.Text = Confirmed.Count().ToString();

            listBox1.Items.Clear();
            List<string> linur = new List<string>();
            try
            {
                linur = database.IpAdresses();

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

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            //do whatever you want 
            RefreshMyForm();
        }

        private void RefreshMyForm()
        {
            List<int> Registered = database.UserCount();
            tbINFORegistered.Text = Registered.Count().ToString();

            List<int> Online = database.UserOnline();
            lbOnline.Text = Online.Count().ToString();

            List<int> Confirmed = database.UserConfirmed();
            tbINFOConfirmed.Text = Confirmed.Count().ToString();

            listBox1.Items.Clear();
            List<string> linur = new List<string>();
            try
            {
                linur = database.IpAdresses();

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

        private void cbOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
            InfoOnTop infotop = new InfoOnTop();
            infotop.Show();
        }
    }
}
