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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void butClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDesktop fd = new frmDesktop();
            fd.Show();
        }
    }
}
