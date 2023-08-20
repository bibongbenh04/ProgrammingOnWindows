namespace BidaManagementApp
{
    partial class TatCaHoaDon
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btFindSP = new System.Windows.Forms.Button();
            this.cbbTang = new System.Windows.Forms.ComboBox();
            this.cbbXapXep = new System.Windows.Forms.ComboBox();
            this.dtGVFullBill = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVFullBill)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(225, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 22);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 52);
            this.label1.TabIndex = 12;
            this.label1.Text = "TẤT CẢ HÓA ĐƠN";
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "dd/MM/yyyy";
            this.dtDate.Enabled = false;
            this.dtDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtDate.Location = new System.Drawing.Point(89, 169);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(130, 22);
            this.dtDate.TabIndex = 13;
            this.dtDate.ValueChanged += new System.EventHandler(this.dtDate_ValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Ngày Tạo Hóa Đơn"});
            this.comboBox2.Location = new System.Drawing.Point(57, 129);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(186, 26);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.Text = "Theo";
            // 
            // btFindSP
            // 
            this.btFindSP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btFindSP.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFindSP.ForeColor = System.Drawing.Color.Black;
            this.btFindSP.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btFindSP.Location = new System.Drawing.Point(306, 67);
            this.btFindSP.Name = "btFindSP";
            this.btFindSP.Size = new System.Drawing.Size(186, 61);
            this.btFindSP.TabIndex = 10;
            this.btFindSP.Text = "Lọc Hóa Đơn";
            this.btFindSP.UseVisualStyleBackColor = false;
            // 
            // cbbTang
            // 
            this.cbbTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTang.FormattingEnabled = true;
            this.cbbTang.Items.AddRange(new object[] {
            "Cả 2 Tầng",
            "Tầng 1",
            "Tầng 2"});
            this.cbbTang.Location = new System.Drawing.Point(306, 129);
            this.cbbTang.Name = "cbbTang";
            this.cbbTang.Size = new System.Drawing.Size(186, 26);
            this.cbbTang.TabIndex = 11;
            this.cbbTang.Text = "Tầng";
            this.cbbTang.SelectedIndexChanged += new System.EventHandler(this.cbbTang_SelectedIndexChanged);
            // 
            // cbbXapXep
            // 
            this.cbbXapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbXapXep.FormattingEnabled = true;
            this.cbbXapXep.Items.AddRange(new object[] {
            "Mã Bàn",
            "Ngày Tạo",
            "Tên Khách Hàng"});
            this.cbbXapXep.Location = new System.Drawing.Point(540, 129);
            this.cbbXapXep.Name = "cbbXapXep";
            this.cbbXapXep.Size = new System.Drawing.Size(186, 26);
            this.cbbXapXep.TabIndex = 11;
            this.cbbXapXep.Text = "Sắp Xếp Theo";
            // 
            // dtGVFullBill
            // 
            this.dtGVFullBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVFullBill.Location = new System.Drawing.Point(12, 211);
            this.dtGVFullBill.Name = "dtGVFullBill";
            this.dtGVFullBill.RowHeadersWidth = 51;
            this.dtGVFullBill.RowTemplate.Height = 24;
            this.dtGVFullBill.Size = new System.Drawing.Size(776, 485);
            this.dtGVFullBill.TabIndex = 17;
            this.dtGVFullBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVFullBill_CellContentClick);
            // 
            // TatCaHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 637);
            this.Controls.Add(this.dtGVFullBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.cbbXapXep);
            this.Controls.Add(this.cbbTang);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btFindSP);
            this.Name = "TatCaHoaDon";
            this.Text = "TatCaHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dtGVFullBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btFindSP;
        private System.Windows.Forms.ComboBox cbbTang;
        private System.Windows.Forms.ComboBox cbbXapXep;
        private System.Windows.Forms.DataGridView dtGVFullBill;
    }
}