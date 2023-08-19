namespace BidaManagementApp
{
    partial class ThongTinBanBida
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
            this.btEditBan = new System.Windows.Forms.Button();
            this.txtMasp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGVBanBida = new System.Windows.Forms.DataGridView();
            this.cbMabanTT = new System.Windows.Forms.ComboBox();
            this.cbTangTT = new System.Windows.Forms.ComboBox();
            this.Tầng = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTTDonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTinhTrangTT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVBanBida)).BeginInit();
            this.SuspendLayout();
            // 
            // btEditBan
            // 
            this.btEditBan.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditBan.Location = new System.Drawing.Point(454, 156);
            this.btEditBan.Name = "btEditBan";
            this.btEditBan.Size = new System.Drawing.Size(78, 43);
            this.btEditBan.TabIndex = 12;
            this.btEditBan.Text = "Edit";
            this.btEditBan.UseVisualStyleBackColor = true;
            this.btEditBan.Click += new System.EventHandler(this.btEditBan_Click);
            // 
            // txtMasp
            // 
            this.txtMasp.AutoSize = true;
            this.txtMasp.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasp.Location = new System.Drawing.Point(19, 130);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(75, 24);
            this.txtMasp.TabIndex = 11;
            this.txtMasp.Text = "Mã Bàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 52);
            this.label1.TabIndex = 10;
            this.label1.Text = "THÔNG TIN BÀN BIDA";
            // 
            // dtGVBanBida
            // 
            this.dtGVBanBida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVBanBida.Location = new System.Drawing.Point(23, 205);
            this.dtGVBanBida.Name = "dtGVBanBida";
            this.dtGVBanBida.RowHeadersWidth = 51;
            this.dtGVBanBida.RowTemplate.Height = 24;
            this.dtGVBanBida.Size = new System.Drawing.Size(509, 458);
            this.dtGVBanBida.TabIndex = 15;
            this.dtGVBanBida.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVBanBida_CellClick);
            this.dtGVBanBida.SelectionChanged += new System.EventHandler(this.dtGVBanBida_SelectionChanged);
            // 
            // cbMabanTT
            // 
            this.cbMabanTT.FormattingEnabled = true;
            this.cbMabanTT.Location = new System.Drawing.Point(108, 130);
            this.cbMabanTT.Name = "cbMabanTT";
            this.cbMabanTT.Size = new System.Drawing.Size(121, 24);
            this.cbMabanTT.TabIndex = 16;
            this.cbMabanTT.SelectedIndexChanged += new System.EventHandler(this.cbMabanTT_SelectedIndexChanged);
            // 
            // cbTangTT
            // 
            this.cbTangTT.FormattingEnabled = true;
            this.cbTangTT.Items.AddRange(new object[] {
            "Cả 2 Tầng",
            "Tầng 1",
            "Tầng 2"});
            this.cbTangTT.Location = new System.Drawing.Point(108, 89);
            this.cbTangTT.Name = "cbTangTT";
            this.cbTangTT.Size = new System.Drawing.Size(121, 24);
            this.cbTangTT.TabIndex = 17;
            this.cbTangTT.Text = "Cả 2 Tầng";
            this.cbTangTT.SelectedIndexChanged += new System.EventHandler(this.cbTangTT_SelectedIndexChanged);
            // 
            // Tầng
            // 
            this.Tầng.AutoSize = true;
            this.Tầng.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tầng.Location = new System.Drawing.Point(19, 87);
            this.Tầng.Name = "Tầng";
            this.Tầng.Size = new System.Drawing.Size(55, 24);
            this.Tầng.TabIndex = 11;
            this.Tầng.Text = "Tầng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đơn Giá";
            // 
            // txtTTDonGia
            // 
            this.txtTTDonGia.Location = new System.Drawing.Point(367, 130);
            this.txtTTDonGia.Name = "txtTTDonGia";
            this.txtTTDonGia.Size = new System.Drawing.Size(164, 22);
            this.txtTTDonGia.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tình Trạng";
            // 
            // cbbTinhTrangTT
            // 
            this.cbbTinhTrangTT.FormattingEnabled = true;
            this.cbbTinhTrangTT.Items.AddRange(new object[] {
            "Chưa Sử Dụng",
            "Đang Sử Dụng"});
            this.cbbTinhTrangTT.Location = new System.Drawing.Point(367, 87);
            this.cbbTinhTrangTT.Name = "cbbTinhTrangTT";
            this.cbbTinhTrangTT.Size = new System.Drawing.Size(121, 24);
            this.cbbTinhTrangTT.TabIndex = 16;
            // 
            // ThongTinBanBida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 609);
            this.Controls.Add(this.txtTTDonGia);
            this.Controls.Add(this.cbTangTT);
            this.Controls.Add(this.cbbTinhTrangTT);
            this.Controls.Add(this.cbMabanTT);
            this.Controls.Add(this.dtGVBanBida);
            this.Controls.Add(this.btEditBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tầng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMasp);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinBanBida";
            this.Text = "ThongTinBanBida";
            this.Load += new System.EventHandler(this.ThongTinBanBida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVBanBida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btEditBan;
        private System.Windows.Forms.Label txtMasp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGVBanBida;
        private System.Windows.Forms.ComboBox cbMabanTT;
        private System.Windows.Forms.ComboBox cbTangTT;
        private System.Windows.Forms.Label Tầng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTTDonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTinhTrangTT;
    }
}