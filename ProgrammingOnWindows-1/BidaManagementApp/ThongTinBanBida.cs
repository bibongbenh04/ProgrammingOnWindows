using BidaManagementApp.DAO;
using BidaManagementApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BidaManagementApp
{
    public partial class ThongTinBanBida : Form
    {
        public ThongTinBanBida()
        {
            InitializeComponent();
            Load_BanBida();
            Load_TTCBMaBan();
        }

        private void Load_TTCBMaBan()
        {
            string query = "select MABAN from BANBIDA  ";
            DataTable table = new DataTable();
            if (cbTangTT.SelectedIndex == 1)
            {
                query += (" WHERE MABAN NOT LIKE 'BAN2.%' ");
            }
            else if (cbTangTT.SelectedIndex == 2)
            {
                query += (" WHERE MABAN LIKE 'BAN2.%' ");
            }
            query += "ORDER BY MABAN";
            table = DataProvider.Instance.ExecuteQuery(query);
            cbMabanTT.Items.Clear();
            foreach (DataRow dr in table.Rows)
            {
                cbMabanTT.Items.Add(dr["MABAN"].ToString());
            }
            if (cbMabanTT.Items.Count > 0)
            {
                cbMabanTT.SelectedIndex = 0;
            }
        }
        private void ThongTinBanBida_Load(object sender, EventArgs e)
        {

        }

        private void Load_ThongTinVaSuaBan()
        {
            DataTable table = new DataTable();
            table = DataProvider.Instance.ExecuteQuery(string.Format("select * from BANBIDA where MABAN = '{0}'", cbMabanTT.Text.ToString()));

            foreach (DataRow dr in table.Rows)
            {
                txtTTDonGia.Text = dr["PRICE"].ToString();
                if (dr["TRANGTHAI"].ToString() == "1")
                    cbbTinhTrangTT.SelectedIndex = 1;
                else
                    cbbTinhTrangTT.SelectedIndex = 0;

            }
        }

        private void Load_BanBida()
        {
            string query = "SELECT * FROM BANBIDA ";
            if (cbTangTT.SelectedIndex == 1)
            {
                query += (" WHERE MABAN NOT LIKE 'BAN2.%' ");
            }
            else if (cbTangTT.SelectedIndex == 2)
            {
                query += (" WHERE MABAN LIKE 'BAN2.%' ");
            }
            query += " ORDER BY MABAN";
            DataProvider data = new DataProvider();
            dtGVBanBida.DataSource = data.ExecuteNonQuery(query);
        }

        private void cbTangTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_TTCBMaBan();
            Load_BanBida();
        }

        private void cbMabanTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_ThongTinVaSuaBan();    
        }

        private void btEditBan_Click(object sender, EventArgs e)
        {
            string tinhtrang;
            if (cbbTinhTrangTT.SelectedIndex == 1) tinhtrang = "1";
            else tinhtrang = "0";
            string query = string.Format("UPDATE BANBIDA SET TRANGTHAI = {0}, PRICE = {1} WHERE MABAN = '{2}'", tinhtrang, txtTTDonGia.Text, cbMabanTT.Text);
            DataProvider data = new DataProvider();
            data.ExecuteQuery(query);
            Load_BanBida();
            MessageBox.Show(string.Format("🔧 Chỉnh sửa thông tin Bàn {0} Thành Công ❤️", cbMabanTT.Text.Substring(3)));
        }

        private void dtGVBanBida_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn hay không
            if (dtGVBanBida.SelectedRows.Count > 0)
            {
                // Lấy chỉ số dòng đầu tiên được chọn
                int selectedRowIndex = dtGVBanBida.SelectedRows[0].Index;

                // Lấy giá trị của cột "Maban" tại dòng đang được chọn
                string selectedMaban = dtGVBanBida.Rows[selectedRowIndex].Cells["MABAN"].Value.ToString();

                // Cập nhật giá trị của ComboBox cbMabanTT
                cbMabanTT.Text = selectedMaban;
            }
        }

        private void dtGVBanBida_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell selectedCell = dtGVBanBida.Rows[e.RowIndex].Cells[0];

                if (selectedCell.Value != null)
                {
                    string selectedMaban = selectedCell.Value.ToString();
                    cbMabanTT.Text = selectedMaban;
                }
            }
        }
    }
}
