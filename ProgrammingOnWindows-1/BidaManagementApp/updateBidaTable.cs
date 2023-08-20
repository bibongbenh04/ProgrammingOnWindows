using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BidaManagementApp.DTO;

namespace BidaManagementApp
{
    public partial class updateBidaTable : Form
    {
        string strConnection = @"Data Source = LAPTOP-BIBONGBE\HONGQUAN_SEVER; Initial catalog = BIDA; Integrated Security = True";
        SqlConnection sqlConnection = null;
        string maban = "";
        public updateBidaTable()
        {
            InitializeComponent();
        }
        // Method
        #region methhod
        private void showListTable()
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(strConnection);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from BANBIDA";
            cmd.Connection = sqlConnection;
            SqlDataReader dr = cmd.ExecuteReader();
            lvDSTABLE.Items.Clear();
            while (dr.Read())
            {
                string maban = dr.GetString(0);
                int trangthai = dr.GetInt32(1);
                double gia = (float)dr.GetDouble(2);
                ListViewItem lv = new ListViewItem(maban);
                lv.SubItems.Add(trangthai.ToString());
                lv.SubItems.Add(gia.ToString());
                lvDSTABLE.Items.Add(lv);
            }
            dr.Close();
        }

        //update table
        private void updateTable(string maban)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(strConnection);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "update BANBIDA set MABAN='" + tbMaban.Text.Trim() + "',TRANGTHAI='" + cbTrangThai.Text.Trim() + "',PRICE='" + tbGia.Text.Trim() + "' where MABAN='" + maban + "'";
            cmd.Connection = sqlConnection;

            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Succeed");
                showListTable();

            }
            else
            {
                MessageBox.Show("Unsucceed");
            }
        }
        //delete table
        private void deleteTable(string maban)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(strConnection);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "delete from BANBIDA where MABAN='" + maban + "'";
            cmd.Connection = sqlConnection;

            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Delete table:" + maban + " successfully");
                showListTable();

            }
            else
            {
                MessageBox.Show("Delete table:" + maban + " failed");
            }
        }
        //check space
        public String Space(int nums)
        {
            String temp = "";

            for (int i = 0; i < nums; ++i)
                temp += " ";

            return temp;
        }

        #endregion


        //Event
        #region Event
        private void updateBidaTable_Load(object sender, EventArgs e)
        {
            showListTable();
        }

        private void lvDSTABLE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSTABLE.SelectedItems.Count == 0) return;

            ListViewItem lv = lvDSTABLE.SelectedItems[0];
            maban = lv.SubItems[0].Text.Trim();
            tbMaban.Text = lv.SubItems[0].Text;
            cbTrangThai.Text = lv.SubItems[1].Text;
            tbGia.Text = lv.SubItems[2].Text;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if ((tbMaban.Text == Space(tbMaban.Text.Length) || cbTrangThai.Items.Count == 0 || tbGia.Text == Space(tbGia.Text.Length)) && (lvDSTABLE.Items.Count < 0))
            {
                MessageBox.Show("Please do again !!");
            }
            else
            {
                updateTable(maban);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lvDSTABLE.Items.Count < 0)
            {
                MessageBox.Show("Please select table!!");
            }
            else
            {
                deleteTable(maban);
            }
        }
        #endregion

    }
}
