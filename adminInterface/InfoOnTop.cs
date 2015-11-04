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
    public partial class InfoOnTop : Form
    {
        DatabaseMain database = new DatabaseMain();
        public InfoOnTop()
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

        private void InfoOnTop_Load(object sender, EventArgs e)
        {
            this.TopMost = cbOnTop.Checked;

            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 200;//5 minutes
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

        private void cbOnTop_CheckStateChanged(object sender, EventArgs e)
        {
            this.Close();
            Info info = new Info();
            info.Show();
        }
    }
}
