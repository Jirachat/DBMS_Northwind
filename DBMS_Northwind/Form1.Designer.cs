namespace DBMS_Northwind
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvShippers = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtShipperID = new TextBox();
            txtCompanyName = new TextBox();
            txtPhone = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShippers).BeginInit();
            SuspendLayout();
            // 
            // dgvShippers
            // 
            dgvShippers.AllowUserToAddRows = false;
            dgvShippers.AllowUserToDeleteRows = false;
            dgvShippers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShippers.Location = new Point(12, 12);
            dgvShippers.Name = "dgvShippers";
            dgvShippers.ReadOnly = true;
            dgvShippers.Size = new Size(776, 150);
            dgvShippers.TabIndex = 0;
            dgvShippers.CellContentClick += dgvShippers_CellContentClick;
            dgvShippers.CellMouseUp += dgvShippers_CellMouseUp;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(677, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "dgvShippers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 242);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 2;
            label1.Text = "รหัสบริษัทขนส่ง";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 277);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "ชื่อบริษัท";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 325);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "โทรศัพท์";
            // 
            // txtShipperID
            // 
            txtShipperID.Location = new Point(191, 234);
            txtShipperID.Name = "txtShipperID";
            txtShipperID.ReadOnly = true;
            txtShipperID.Size = new Size(107, 23);
            txtShipperID.TabIndex = 5;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(191, 277);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(314, 23);
            txtCompanyName.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(191, 322);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(189, 23);
            txtPhone.TabIndex = 7;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Lime;
            btnInsert.Location = new Point(146, 386);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(98, 42);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "เพิ่ม";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(282, 386);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 42);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "ปรับปรุง";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(417, 386);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 42);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "ลบ";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Turquoise;
            btnClear.Location = new Point(546, 386);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 42);
            btnClear.TabIndex = 11;
            btnClear.Text = "ล้างฟอร์ม";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtPhone);
            Controls.Add(txtCompanyName);
            Controls.Add(txtShipperID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dgvShippers);
            Name = "Form1";
            Text = "จัดการข้อมูลบริษัทข่นส่ง(Shippers)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShippers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShippers;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtShipperID;
        private TextBox txtCompanyName;
        private TextBox txtPhone;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}
