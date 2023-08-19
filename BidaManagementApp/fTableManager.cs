using BidaManagementApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BidaManagementApp
{
    public partial class fTableManager : Form
    {
        int i = 0;
        public fTableManager()
        {
            InitializeComponent();
            LoadFull();
        }

        //load thong tin trong SQl
        private void LoadFull()
        {
            LoadComboBoxMaBan();
            LoadThongTinBan();
            LoadListViewBillToDay();
            LoadImageBan();
        }
        private void LoadImageBan()
        {

        }
        private void LoadListViewBillToDay()
        {
            DataProvider provider= new DataProvider();
            string query = " SELECT MABAN 'Mã Bàn', PRICE 'Đơn Giá' FROM BANBIDA WHERE TRANGTHAI = 1 ";
            if (tabControl1.SelectedIndex == 0) query += " AND MABAN NOT LIKE 'BAN2.%' ";
            else query += " AND MABAN LIKE 'BAN2.%' ";
            dtGVBillToday.DataSource = provider.ExecuteNonQuery(query);
            DataTable dt = (DataTable)dtGVBillToday.DataSource;
            List<string> activeMaBanList = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                string maBan = row["Mã Bàn"].ToString();
                activeMaBanList.Add(maBan);
            }
            foreach (TabPage tabPage in tabControl1.TabPages) // Duyệt qua các TabPage trong tabControl1
            {
                foreach (Control control in tabPage.Controls) // Duyệt qua các Control trong TabPage
                {
                    if (control is Label label)
                    {
                        string idBan;
                        string StartNameImg = "Ban";
                        if(label.Name.StartsWith("TANGHAI"))
                        {
                            idBan = "2." + label.Name.Substring(7);
                            StartNameImg += "TangHai";
                        }
                        else
                        {
                            idBan = label.Name.Substring(5);
                        }
                        if (activeMaBanList.Contains("BAN" + idBan))
                        {
                            if(idBan.StartsWith("2."))
                                changeColorPicture(StartNameImg + idBan.Substring(2), "Blue");
                            else
                                changeColorPicture(StartNameImg + idBan, "Blue");

                            // Đổi màu cho Label ở đây khi hoạt động, ví dụ:
                            label.BackColor = Color.Green;
                            label.ForeColor = Color.White;
                        }
                        else
                        {
                            if (idBan.StartsWith("2."))
                                changeColorPicture(StartNameImg + idBan.Substring(2), "Transparent ");
                            else
                                changeColorPicture(StartNameImg + idBan, "Transparent ");

                            // Đổi màu cho Label ở đây khi không hoạt động, ví dụ:
                            label.BackColor = Color.Transparent;
                            label.ForeColor = Color.Black;
                        }
                    }
                }
            }

        }
        private void LoadComboBoxMaBan()
        {
            DataTable table = new DataTable(); 
            if(tabControl1.SelectedIndex == 0)
            {
                    table = DataProvider.Instance.ExecuteQuery("select MABAN from BANBIDA where MABAN NOT LIKE 'BAN2.%' ORDER BY MABAN");
            }
            else
            {
                    table = DataProvider.Instance.ExecuteQuery("select MABAN from BANBIDA where MABAN LIKE 'BAN2.%' ORDER BY MABAN");
            }
            cbMaBan.Items.Clear();
            cbSwitchTable.Items.Clear();
            foreach (DataRow dr in table.Rows)
            {
                cbSwitchTable.Items.Add(dr["MABAN"].ToString());
                cbMaBan.Items.Add(dr["MABAN"].ToString());
            }
            if (cbMaBan.Items.Count > 0)
            {
                Random random = new Random();
                cbMaBan.SelectedIndex = 0;
                int randomIndex = random.Next(0, cbSwitchTable.Items.Count-1);
                cbSwitchTable.SelectedIndex = randomIndex;
            }

        }

        private void LoadThongTinBan()
        {
            DataTable table = new DataTable();
            table = DataProvider.Instance.ExecuteQuery(string.Format("select * from BANBIDA where MABAN = '{0}'", cbMaBan.Text.ToString()));

            foreach (DataRow dr in table.Rows)
            {
                txtDonGia.Text = dr["PRICE"].ToString() + "$";
                if (dr["TRANGTHAI"].ToString() == "1")
                {
                    txtTinhTrang.Text = "Đang Sử Dụng";
                    btStartPlay.Enabled = false;
                }
                else
                {
                    txtTinhTrang.Text = "Chưa Sử Dụng";
                    btStartPlay.Enabled = true;
                }
            }

        }
        //bool check input
        static bool isValidName (string name)
        {
            // Quy tắc: Họ và tên đều chỉ chứa các ký tự chữ cái và có thể có dấu cách.
            string pattern = @"^[\p{L}\s]+$";
            return Regex.IsMatch(name, pattern);
        }
        static bool emptyString (string str)
        {
            if (str == "")
            {
                MessageBox.Show("Vui Lòng Nhập Chuỗi");
                return true;
            }
            return false;
        }

        public bool checkTen(string str)
        {
            if(!emptyString(str) && isValidName(str))
                return true;
            else
            {
                MessageBox.Show("Tên Khách Hàng Chưa Đúng Cú Pháp Hợp Lệ");
                txtNameNguoiTT.Focus();
                return false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            Clock.Text = i.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadComboBoxMaBan();
            LoadListViewBillToDay();
        }

        private void cbMaBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThongTinBan();
        }

        private void btStartPlay_Click(object sender, EventArgs e)
        {
            if(txtTinhTrang.Text == "Đang Sử Dụng")
            {
                MessageBox.Show("❤️ Bàn này đã được sử dụng, Vui Lòng Chọn Bàn Khác ❤️");
                return;
            }
            if (!checkTen(txtNameNguoiTT.Text)) return;
            timer1.Start();
            string playerName = txtNameNguoiTT.Text;
            string idBan = cbMaBan.Text.ToString().Substring(3);
            DateTime currentTime = DateTime.Now;
            string querry = string.Format("UPDATE BANBIDA SET TRANGTHAI = 1 WHERE MABAN = '{0}'", cbMaBan.Text);
            DataProvider dataProvider = new DataProvider();
            dataProvider.ExecuteQuery(querry);
            LoadFull();
            MessageBox.Show(string.Format("❤️Quý khách: {0} \nBắt Đầu Chơi Bàn Số {1} Từ Lúc: {2}. \n\n            Xin cám ơn quý khách ❤️", playerName, idBan, currentTime));
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Clock.Text = "0";
        }

        private void fTableManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if( MessageBox.Show("❗️Bạn Có Muốn Thoát Khỏi Chương Trình ❓", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            cbMaBan.Text = cbSwitchTable.Text;
            int randomIndex = random.Next(0, cbSwitchTable.Items.Count - 1);
            cbSwitchTable.SelectedIndex = randomIndex;
        }

        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TatCaHoaDon tchd = new TatCaHoaDon();
            this.Hide();
            tchd.ShowDialog();
            LoadFull();
            this.Show();
        }

        private void xemSửaToànBộBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinBanBida thongTinBanBida = new ThongTinBanBida();
            this.Hide();
            thongTinBanBida.ShowDialog();
            LoadFull();
            this.Show();

        }

        private void dtGVBillToday_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell selectedCell = dtGVBillToday.Rows[e.RowIndex].Cells[0];

                if (selectedCell.Value != null)
                {
                    string selectedMaban = selectedCell.Value.ToString();
                    cbMaBan.Text = selectedMaban;
                }
            }
        }

        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        private void ClickPicture(object sender, EventArgs e)
        {
            LoadListViewBillToDay();
            PictureBox clickedPictureBox = sender as PictureBox;
            // Lấy tên của PictureBox đang chọn
            string MaBanDuocChon = clickedPictureBox.Name;
            if(MaBanDuocChon.StartsWith("BanTangHai"))
            {
                MaBanDuocChon = "BAN2." + MaBanDuocChon.Substring(10);
            }
            else
            {
                MaBanDuocChon = "BAN" + MaBanDuocChon.Substring(3);
            }
            cbMaBan.Text = MaBanDuocChon;
            cbMaBan.Focus();
            string tinhtrang = txtTinhTrang.Text;

            changeColorPicture(clickedPictureBox.Name, "Red");
        }
        private bool changeColorPicture(string pictureBoxName, string color)
        {
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                PictureBox pic = tabPage.Controls.Find(pictureBoxName, true).FirstOrDefault() as PictureBox;
                if (pic != null)
                {
                    pic.BackColor = Color.FromName(color); // Thay đổi màu nền của viền
                    pic.Refresh(); // Cập nhật lại hiển thị của PictureBox
                    return true;
                }
            }

            return false;
        }
    }
}
