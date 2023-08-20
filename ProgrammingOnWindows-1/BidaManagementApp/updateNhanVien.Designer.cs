namespace BidaManagementApp
{
    partial class updateNhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMANV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.lvDSNV = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtNgaysinh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbChucVu);
            this.panel1.Controls.Add(this.tbHoten);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbMANV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(46, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 267);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chuc Vu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ho Ten";
            // 
            // tbMANV
            // 
            this.tbMANV.Location = new System.Drawing.Point(68, 68);
            this.tbMANV.Name = "tbMANV";
            this.tbMANV.Size = new System.Drawing.Size(122, 20);
            this.tbMANV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ma NV";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btDelete);
            this.panel2.Controls.Add(this.btUpdate);
            this.panel2.Location = new System.Drawing.Point(46, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 46);
            this.panel2.TabIndex = 6;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(175, 3);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(66, 40);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click_1);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(6, 3);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(66, 40);
            this.btUpdate.TabIndex = 4;
            this.btUpdate.Text = "Add";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click_1);
            // 
            // lvDSNV
            // 
            this.lvDSNV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDSNV.FullRowSelect = true;
            this.lvDSNV.GridLines = true;
            this.lvDSNV.HideSelection = false;
            this.lvDSNV.Location = new System.Drawing.Point(339, 118);
            this.lvDSNV.Name = "lvDSNV";
            this.lvDSNV.Size = new System.Drawing.Size(381, 267);
            this.lvDSNV.TabIndex = 7;
            this.lvDSNV.UseCompatibleStateImageBehavior = false;
            this.lvDSNV.View = System.Windows.Forms.View.Details;
            this.lvDSNV.SelectedIndexChanged += new System.EventHandler(this.lvDSNV_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhân Viên";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MANV";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "HOTEN";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CHUCVU";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "NGAYSINH";
            this.columnHeader4.Width = 100;
            // 
            // tbHoten
            // 
            this.tbHoten.Location = new System.Drawing.Point(68, 111);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(122, 20);
            this.tbHoten.TabIndex = 6;
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý"});
            this.cbChucVu.Location = new System.Drawing.Point(69, 153);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(121, 21);
            this.cbChucVu.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngay Sinh";
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Location = new System.Drawing.Point(62, 189);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(200, 20);
            this.dtNgaysinh.TabIndex = 10;
            // 
            // updateNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvDSNV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "updateNhanVien";
            this.Text = "updateNhanVien";
            this.Load += new System.EventHandler(this.updateNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMANV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.ListView lvDSNV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
    }
}