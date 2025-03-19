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
    public partial class frmManufacturer : Form
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand();
        public frmManufacturer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnlg_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDesktop fd = new frmDesktop();
            fd.Show();
        }

        private void frmManufacturer_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            LoadGridViewData();
        }

        public void LoadGridViewData()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblManufacture", con);
            sda.Fill(ds, "tblManufacture");
            dgvManufacture.DataSource = ds.Tables[0];
        }

        public int SID;
        public void Clear_Data()
        {
            txtName.Text = " ";
            txtAddress.Text = " ";
            txtPhone.Text = " ";
            txtEmail.Text = " ";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cmd.Connection = con;

            cmd.CommandText = "insert into tblManufacture values('" + txtName.Text.ToUpper().Trim()
                                                    + "','" + txtAddress.Text.ToUpper().Trim()
                                                    + "','" + txtPhone.Text.Trim()
                                                    + "','" + txtEmail.Text.ToUpper().Trim()
                                                    + "')";
            con.Open();

            cmd.ExecuteNonQuery();

            Clear_Data();

            con.Close();
            MessageBox.Show("Record Saved");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear_Data();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd.CommandText = "delete from tblManufacture where mid = " + SID;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted");
        }

        private void txtMFName_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string query = "select * from tblManufacture where mname like '" + txtMFName.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(ds, "tblManufacture");
            dgvManufacture.DataSource = ds.Tables["tblManufacture"];
        }

        private void dgvManufacture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlDataReader sdr;
            SID = Convert.ToInt32(dgvManufacture.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmd.CommandText = "select * from tblManufacture where mid =" + SID;
            cmd.Connection = con;
            con.Open();
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtName.Text = sdr[1].ToString();
                txtAddress.Text = sdr[2].ToString();
                txtPhone.Text = sdr[3].ToString();
                txtEmail.Text = sdr[4].ToString();
                
            }

            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlParameter p1 = new SqlParameter("@mname", SqlDbType.VarChar);
            p1.Value = txtName.Text.ToUpper().Trim();
            SqlParameter p2 = new SqlParameter("@maddress", SqlDbType.VarChar);
            p2.Value = txtAddress.Text.ToUpper().Trim();
            SqlParameter p3 = new SqlParameter("@mphone", SqlDbType.NVarChar);
            p3.Value = txtPhone.Text;
            SqlParameter p4 = new SqlParameter("@memail", SqlDbType.VarChar);
            p4.Value = txtEmail.Text.ToUpper().Trim();
            

            cmd.Parameters.Clear();
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            


            cmd.Connection = con;


            cmd.CommandText = "update tblManufacture set mname=@mname, maddress=@maddress, mphone=@mphone,memail=@memail where mid =" + SID;


            con.Open();


            cmd.ExecuteNonQuery();


            con.Close();
            MessageBox.Show("Record Update");
        }
    }
}
