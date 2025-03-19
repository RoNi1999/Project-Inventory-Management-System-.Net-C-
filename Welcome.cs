using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTORY_MANAGMENT_SYSTEM
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin log = new frmLogin();
            log.Show();
            timer1.Enabled = false;
        }
    }
}
