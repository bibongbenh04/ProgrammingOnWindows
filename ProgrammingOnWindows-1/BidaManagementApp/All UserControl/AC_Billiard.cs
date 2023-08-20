using BidaManagementApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BidaManagementApp.All_UserControl
{
    public partial class AC_Billiard : UserControl
    {
        public AC_Billiard()
        {
            InitializeComponent();
        }

        private void cbbCoTy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCoTy.SelectedIndex == 0)
            {
                txtPrice.Text = "1000 $";
            }
            else if (cbbCoTy.SelectedIndex == 1)
            {
                txtPrice.Text = "10000 $";
            }
            else txtPrice.Text = "500000 $";
        }

        private void defaultSelection()
        {
            txtTableNu.Text = "";
            cbbCoTy.SelectedIndex = 0;
            cbbTableTy.SelectedIndex = 0;
            txtPrice.Text = "1000 $";
        }
        //load database
        private void load_dtgvTable()
        {
            string query = "SELECT MABAN 'Mã Bàn', PRICE 'Đơn Giá', TRANGTHAI 'Trạng Thái' FROM BANBIDA";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(query);
            dtgvNewTable.DataSource = dt;
        }
        private void AC_Billiard_Load(object sender, EventArgs e)
        {
            defaultSelection();
            load_dtgvTable();
        }


        private void clearAllInput()
        {
            txtPrice.Text = string.Empty;
            txtTableNu.Text = string.Empty;
            cbbTableTy.SelectedIndex = 0;
            cbbCoTy.SelectedIndex = 0;
        }
        private bool checkFullInput()
        {
            if(txtTableNu.Text.Trim() == "")
            {
                txtTableNu.Focus();
                return false;
            }
            return true;
        }
        private void UC_AddTable_Click(object sender, EventArgs e)
        {
            if(!checkFullInput()) return;
            MessageBox.Show("Add New Table", "Success ");
            defaultSelection();
        }
    }
}
