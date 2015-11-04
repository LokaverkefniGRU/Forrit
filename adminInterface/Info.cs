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
            List<int> Registered = database.UserCount();
            tbINFORegistered.Text = Registered.Count().ToString();

            List<int> Online = database.UserOnline();
            lbOnline.Text = Online.Count().ToString();

            List<int> Confirmed = database.UserConfirmed();
            tbINFOConfirmed.Text = Confirmed.Count().ToString();
        }


    }
}
