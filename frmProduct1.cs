using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace INVENTORY_MANAGMENT_SYSTEM
{
    public partial class frmProduct1 : Form
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand();
        public frmProduct1()
        {
            InitializeComponent();
        }

        public int SID;
        private void frmProduct1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            Loadcmb();

            LoadGridViewData();
        }

        public void Loadcmb()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tblProduct", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbManufactureID.DataSource = dt;
            cmbManufactureID.DisplayMember = "tblProduct";
            cmbManufactureID.ValueMember = "ID";
            cmbModelNo.DataSource = dt;
            cmbSuppID.DataSource = dt;
        }

        public void LoadGridViewData()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblProduct", con);
            sda.Fill(ds, "tblProduct");
            dgvManufacture.DataSource = ds.Tables[0];
        }

        private void btnlg_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDesktop fd = new frmDesktop();
            fd.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0); 
        }

        public void Clear_Data()
        {
            txtName.Text = " ";
            txtPrice.Text = " ";
            cmbModelNo.Text = " ";
            cmbSuppID.Text = " ";
            cmbManufactureID.Text = " ";
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            cmd.Connection = con;

            cmd.CommandText = "insert into tblProduct values('" + txtName.Text.ToUpper().Trim()
                                                    + "','" + txtPrice.Text.ToUpper().Trim()
                                                    + "','" + cmbModelNo.SelectedItem.ToString()
                                                    + "','" + cmbSuppID.SelectedItem.ToString()
                                                    + "','" + cmbManufactureID.SelectedItem.ToString() + "')";
            con.Open();

            cmd.ExecuteNonQuery();

            Clear_Data();

            con.Close();
            MessageBox.Show("Record Saved");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear_Data() ;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd.CommandText = "delete from tblProduct where pid = " + SID;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted");
        }

        private void txtPDName_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string query = "select * from tblProduct where pname like '" + txtPDName.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(ds, "tblProduct");
            dgvManufacture.DataSource = ds.Tables["tblProduct"];
        }

        private void dgvManufacture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlDataReader sdr;
            SID = Convert.ToInt32(dgvManufacture.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmd.CommandText = "select * from tblProduct where pid =" + SID;
            cmd.Connection = con;
            con.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtName.Text = sdr[1].ToString();
                txtPrice.Text = sdr[2].ToString();
                cmbModelNo.SelectedItem = sdr[3].ToString();
                cmbSuppID.SelectedItem = sdr[4].ToString();
                cmbManufactureID.SelectedItem = sdr[5].ToString();    
            }

            con.Close();
        }
    }
}
