using Microsoft.Data.SqlClient;
using System.Data;

namespace DBMS_Northwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void dgvShippers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnecNorthwind();
            //if (conn.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("เชื่อมต่อฐานข้อมูลเรียบร้อย", "Database Connected");
            //}
            showdata();
        }
        private void showdata()
        {
            string sql = "Select * from Shippers";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvShippers.DataSource = ds.Tables[0];
        }

        private void dgvShippers_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtShipperID.Text = dgvShippers.CurrentRow.Cells[0].Value.ToString();
            txtCompanyName.Text = dgvShippers.CurrentRow.Cells[1].Value.ToString();
            txtPhone.Text = dgvShippers.CurrentRow.Cells[2].Value.ToString();
        }

        private void clearForm()
        {
            txtShipperID.Clear();
            txtCompanyName.Clear();
            txtPhone.Clear();
            txtCompanyName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("โปรดกรอกชื่อบริษัท", "เกิดข้อผิดพลาด");
                return;
            }
            string sql = "Insert into shippers"
                        + " Values(@companyName,@phone)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                showdata();
                clearForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtShipperID.Text))
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะแก้ไข", "เกิดข้อผิดพลาด");
                return;
            }
            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("โปรดกรอกชื่อบริษัท", "เกิดข้อผิดพลาด");
                return;
            }
            string sql = "Update shippers"
                        + " Set CompanyName = @companyName,phone = @phone"
                        + " where ShipperID = @shipperID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@shipperID", txtShipperID.Text);
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                showdata();
                clearForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการลบข้อมูลชุดนี้หรือไม่","ยืนยัน?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            if (string.IsNullOrEmpty(txtShipperID.Text))
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะลบ", "เกิดข้อผิดพลาด");
                return;
            }
            string sql = "Delete from shippers"
                        + " where ShipperID = @shipperID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@shipperID", txtShipperID.Text);
            try
            {
            int n = cmd.ExecuteNonQuery();
                        if (n > 0)
                        {
                            showdata();
                            clearForm();
                        }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("เกิดข้อผิดพลาด" + Environment.NewLine + ex.Message, "Error!!!");
            }
        }
    }
}
