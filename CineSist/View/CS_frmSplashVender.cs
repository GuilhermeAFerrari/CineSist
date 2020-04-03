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
    public partial class CS_frmSplashVender : Form
    {
        public CS_frmSplashVender()
        {
            InitializeComponent();
        }

        private void tmpImprimir_Tick(object sender, EventArgs e)
        {
            if (pgbImprimir.Value < 100)
            {
                pgbImprimir.Value += 10;
            }
            else
            {
                tmpImprimir.Enabled = false;
                this.Visible = false;
            }
        }
    }
}
