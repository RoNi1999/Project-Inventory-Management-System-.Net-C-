using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace INVENTORY_MANAGMENT_SYSTEM
{
    public partial class frmSupplier : Form
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand();
        public frmSupplier()
        {
            InitializeComponent();
        }

        string Gender;
        public int SID;
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            LoadGridViewData();
        }

        public void LoadGridViewData()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblSupplier", con);
            sda.Fill(ds, "tblSupplier");
            dgvSupplier.DataSource = ds.Tables[0];
        }

        public void SetData(int SID)
        {
            SqlDataReader sdr;
            cmd.CommandText = "select * from tblSupplier where sid =" + SID;
            cmd.Connection = con;
            con.Open();
            sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                txtName.Text = sdr[1].ToString();
                txtAddress.Text = sdr[2].ToString();
                txtPhone.Text = sdr[3].ToString();  
                txtEmail.Text = sdr[4].ToString();
                if (sdr[5].ToString().Trim()=="Male")
                    rbMale.Checked = true;
                else 
                    rbFemale.Checked = true;
            }
            con.Close();
        }

        private void btnlg_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDesktop fd = new frmDesktop();
            fd.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(rbFemale.Checked==true)
                Gender = rbFemale.Text;
            if(rbMale.Checked==true)
                Gender = rbMale.Text;

            cmd.Connection = con;

            cmd.CommandText = "insert into tblSupplier values('" + txtName.Text.ToUpper().Trim()
                                                    +"','"+ txtAddress.Text.ToUpper().Trim()
                                                    +"','"+ txtPhone.Text.Trim()
                                                    +"','"+ txtEmail.Text.ToUpper().Trim()
                                                    +"','"+ Gender +"')";
            con.Open();

            cmd.ExecuteNonQuery();

            Clear_Data();

            con.Close();
            MessageBox.Show("Record Saved");
        }

        public void Clear_Data()
        {
            txtName.Text = " ";
            txtAddress.Text = " ";
            txtPhone.Text = " ";    
            txtEmail.Text = " ";    
            if(rbFemale.Checked==true)
                rbFemale.Checked = false;
            else
                rbMale.Checked = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd.CommandText = "delete from tblSupplier where sid = " + SID;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted");
        }

        private void txtSUPPName_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string query = "select * from tblSupplier where sname like '" + txtSUPPName.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(ds, "tblSupplier");
            dgvSupplier.DataSource = ds.Tables["tblSupplier"];
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlDataReader sdr;
            SID = Convert.ToInt32(dgvSupplier.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmd.CommandText = "select * from tblSupplier where sid =" + SID;
            cmd.Connection = con;
            con.Open();
            sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                txtName.Text = sdr[1].ToString();
                txtAddress.Text = sdr[2].ToString();
                txtPhone.Text = sdr[3].ToString();
                txtEmail.Text = sdr[4].ToString();
                if (sdr[5].ToString().Trim() == "Male")
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;
            }
            
            con.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlParameter p1 = new SqlParameter("@sname", SqlDbType.VarChar);
            p1.Value = txtName.Text.ToUpper().Trim();
            SqlParameter p2 = new SqlParameter("@saddress", SqlDbType.VarChar);
            p2.Value = txtAddress.Text.ToUpper().Trim();
            SqlParameter p3 = new SqlParameter("@sphone", SqlDbType.NVarChar);
            p3.Value = txtPhone.Text;
            SqlParameter p4 = new SqlParameter("@semail", SqlDbType.VarChar);
            p4.Value = txtEmail.Text.ToUpper().Trim();
            SqlParameter p5 = new SqlParameter("@sgender", SqlDbType.Char);
            if (rbFemale.Checked == true)
                p5.Value = rbFemale.Text;
            if (rbMale.Checked == true)
                p5.Value = rbMale.Text;

            cmd.Parameters.Clear();
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);


            cmd.Connection = con;


            cmd.CommandText = "update tblSupplier set sname=@sname, saddress=@saddress, sphone=@sphone,semail=@semail,sgender=@sgender where sid =" + SID;

            
            con.Open();

            
            cmd.ExecuteNonQuery();

            
            con.Close();
            MessageBox.Show("Record Update");
        }

        private void butNew_Click(object sender, EventArgs e)
        {
            Clear_Data();
        }
    }
}
