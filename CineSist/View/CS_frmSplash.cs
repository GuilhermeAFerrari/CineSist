using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineSist
{
    public partial class CS_frmSplash : Form
    {
        public CS_frmSplash()
        {
            InitializeComponent();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            if (pgbSplash.Value < 100)
            {
                pgbSplash.Value += 2;
            }
            else
            {
                tmrSplash.Enabled = false;
                this.Visible = false;
                CS_frmLogin frmLogin = new CS_frmLogin();
                frmLogin.Show();
            }
        }
    }
}
