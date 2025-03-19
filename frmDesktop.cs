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
    public partial class frmDesktop : Form
    {
        public frmDesktop()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnManufactor_Click(object sender, EventArgs e)
        {
            frmManufacturer fm = new frmManufacturer();
            fm.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier fs = new frmSupplier();
            fs.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProduct1 fp = new frmProduct1();
            fp.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer fc = new frmCustomer();
            fc.Show();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            frmInvoice fi = new frmInvoice();
            fi.Show();
        }

        
    }
}
