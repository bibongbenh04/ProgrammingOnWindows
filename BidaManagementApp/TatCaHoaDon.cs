using BidaManagementApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BidaManagementApp
{
    public partial class TatCaHoaDon : Form
    {
        public TatCaHoaDon()
        {
            InitializeComponent();
        }

        private void dtGVFullBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string query = "Select "
            //DataProvider data = new DataProvider();
            //dtGVFullBill.DataSource = data.ExecuteNonQuery();

        }

        private void cbbTang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
