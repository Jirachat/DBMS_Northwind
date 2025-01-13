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

        int shipperID = 0;
        string companyName = string.Empty;
        string phone = string.Empty;

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
            shipperID = Convert.ToInt32(dgvShippers.CurrentRow.Cells[0].Value);
            companyName = dgvShippers.CurrentRow.Cells[1].Value.ToString();
            phone = dgvShippers.CurrentRow.Cells[2].Value.ToString();

            //txtShipperID.Text = dgvShippers.CurrentRow.Cells[0].Value.ToString();
            //txtCompanyName.Text = dgvShippers.CurrentRow.Cells[1].Value.ToString();
            //txtPhone.Text = dgvShippers.CurrentRow.Cells[2].Value.ToString();
        }

        private void clearForm()
        {
            //txtShipperID.Clear();
            //txtCompanyName.Clear();
            //txtPhone.Clear();
            //txtCompanyName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmShippers f = new frmShippers();
            f.Status = "insert";
            f.ShowDialog();
            showdata();

            //if (string.IsNullOrEmpty(txtCompanyName.Text))
            //{
            //    MessageBox.Show("โปรดกรอกชื่อบริษัท", "เกิดข้อผิดพลาด");
            //    return;
            //}
            //string sql = "Insert into shippers"
            //            + " Values(@companyName,@phone)";
            //cmd = new SqlCommand(sql, conn);
            //cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
            //cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
            //int n = cmd.ExecuteNonQuery();
            //if (n > 0)
            //{
            //    showdata();
            //    clearForm();
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (shipperID <= 0)
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะปรับปรุงแก้ไข", "เกิดข้อผิดพลาด");
                return;
            }
            frmShippers f = new frmShippers();
            f.Status = "update";
            f.ShipperID = shipperID;
            f.CompanyName = companyName;
            f.Phone = phone;
            f.ShowDialog();
            showdata();

            //if (string.IsNullOrEmpty(txtShipperID.Text))
            //{
            //    MessageBox.Show("โปรดเลือกข้อมูลที่จะแก้ไข", "เกิดข้อผิดพลาด");
            //    return;
            //}
            //if (string.IsNullOrEmpty(txtCompanyName.Text))
            //{
            //    MessageBox.Show("โปรดกรอกชื่อบริษัท", "เกิดข้อผิดพลาด");
            //    return;
            //}
            //string sql = "Update shippers"
            //            + " Set CompanyName = @companyName,phone = @phone"
            //            + " where ShipperID = @shipperID";
            //cmd = new SqlCommand(sql, conn);
            //cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
            //cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
            //cmd.Parameters.AddWithValue("@shipperID", txtShipperID.Text);
            //int n = cmd.ExecuteNonQuery();
            //if (n > 0)
            //{
            //    showdata();
            //    clearForm();
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = shipperID.ToString() + Environment.NewLine;
            msg += "บริษัท :" + companyName;
            msg += "โทร :" + phone;
            if (MessageBox.Show(msg, "ต้องการลบข้อมูลชุดนี้หรือไม่", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            if (shipperID <= 0)
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะลบ", "เกิดข้อผิดพลาด");
                return;
            }
            string sql = "Delete from shippers"
                        + " where ShipperID = @shipperID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@shipperID", shipperID);
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

        private void dgvShippers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnUpdate.PerformClick();
        }
    }
}
