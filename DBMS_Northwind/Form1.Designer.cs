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
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
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
            dgvShippers.Size = new Size(776, 234);
            dgvShippers.TabIndex = 0;
            dgvShippers.CellContentClick += dgvShippers_CellContentClick;
            dgvShippers.CellMouseDoubleClick += dgvShippers_CellMouseDoubleClick;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
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
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
