namespace DBMS_Northwind
{
    partial class frmShippers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPhone = new TextBox();
            txtCompanyName = new TextBox();
            txtShipperID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(255, 167);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(189, 23);
            txtPhone.TabIndex = 13;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(255, 122);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(314, 23);
            txtCompanyName.TabIndex = 12;
            // 
            // txtShipperID
            // 
            txtShipperID.Location = new Point(255, 79);
            txtShipperID.Name = "txtShipperID";
            txtShipperID.ReadOnly = true;
            txtShipperID.Size = new Size(107, 23);
            txtShipperID.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 170);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 10;
            label3.Text = "โทรศัพท์";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 122);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 9;
            label2.Text = "ชื่อบริษัท";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 87);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 8;
            label1.Text = "รหัสบริษัทขนส่ง";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(164, 262);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(387, 262);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "ยกเลิก";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmShippers
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(751, 390);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPhone);
            Controls.Add(txtCompanyName);
            Controls.Add(txtShipperID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmShippers";
            Text = "frmShippers";
            Load += frmShippers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPhone;
        private TextBox txtCompanyName;
        private TextBox txtShipperID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnCancel;
    }
}