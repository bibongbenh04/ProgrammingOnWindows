namespace BidaManagementApp
{
    partial class updateBidaTable
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.tbMaban = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.lvDSTABLE = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bida Table";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbGia);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbTrangThai);
            this.panel1.Controls.Add(this.tbMaban);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(44, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 267);
            this.panel1.TabIndex = 1;
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(68, 156);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(122, 20);
            this.tbGia.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trang Thai";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbTrangThai.Location = new System.Drawing.Point(68, 111);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(121, 21);
            this.cbTrangThai.TabIndex = 2;
            // 
            // tbMaban
            // 
            this.tbMaban.Location = new System.Drawing.Point(68, 68);
            this.tbMaban.Name = "tbMaban";
            this.tbMaban.Size = new System.Drawing.Size(122, 20);
            this.tbMaban.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ma Ban";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btDelete);
            this.panel2.Controls.Add(this.btUpdate);
            this.panel2.Location = new System.Drawing.Point(44, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 46);
            this.panel2.TabIndex = 2;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(175, 3);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(66, 40);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(6, 3);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(66, 40);
            this.btUpdate.TabIndex = 4;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // lvDSTABLE
            // 
            this.lvDSTABLE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvDSTABLE.FullRowSelect = true;
            this.lvDSTABLE.GridLines = true;
            this.lvDSTABLE.HideSelection = false;
            this.lvDSTABLE.Location = new System.Drawing.Point(385, 117);
            this.lvDSTABLE.Name = "lvDSTABLE";
            this.lvDSTABLE.Size = new System.Drawing.Size(303, 267);
            this.lvDSTABLE.TabIndex = 3;
            this.lvDSTABLE.UseCompatibleStateImageBehavior = false;
            this.lvDSTABLE.View = System.Windows.Forms.View.Details;
            this.lvDSTABLE.SelectedIndexChanged += new System.EventHandler(this.lvDSTABLE_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ma Ban";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Trang Thai";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gia";
            this.columnHeader3.Width = 100;
            // 
            // updateBidaTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 469);
            this.Controls.Add(this.lvDSTABLE);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "updateBidaTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BIDA TABLE";
            this.Load += new System.EventHandler(this.updateBidaTable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.TextBox tbMaban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvDSTABLE;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
    }
}