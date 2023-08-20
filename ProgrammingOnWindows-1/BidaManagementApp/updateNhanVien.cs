using BidaManagementApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BidaManagementApp
{
    public partial class updateNhanVien : Form
    {
        string strConnection= @"Data Source = LAPTOP-BIBONGBE\HONGQUAN_SEVER; Initial catalog = BIDA; Integrated Security = True";
        SqlConnection sqlConnection = null;
        string manv = "";
        string newManv = "", newHoten = "", newChucvu = ""; DateTime newNgaysinh;
        public updateNhanVien()
        {
            InitializeComponent();
        }

      
        // Method
        #region methhod
        private void showListNhanVien()
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
            cmd.CommandText = "select *from NHANVIEN";
            cmd.Connection = sqlConnection;
            SqlDataReader dr = cmd.ExecuteReader();
            lvDSNV.Items.Clear();
            while (dr.Read())
            {
                string manv = dr.GetString(0);
                string hoten = dr.GetString(1);
                string chucvu = dr.GetString(2);
                DateTime dateTime=dr.GetDateTime(3);
                ListViewItem lv = new ListViewItem(manv);
                lv.SubItems.Add(hoten.ToString());
                lv.SubItems.Add(chucvu.ToString());
                lv.SubItems.Add(dateTime.ToString());
                lvDSNV.Items.Add(lv);
            }
            dr.Close();
        }

        //update NhanVien
        private void addNhanVien(string newManv, string newHoten, string newChucvu, DateTime newNgaysinh)
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

            cmd.CommandText = "INSERT INTO NHANVIEN VALUES ( @NewManv,  @NewHoten, @NewChucvu,  @NewNgaysinh)";
            cmd.Parameters.AddWithValue("@NewManv", newManv);
            cmd.Parameters.AddWithValue("@NewHoten", newHoten);
            cmd.Parameters.AddWithValue("@NewChucvu", newChucvu);
            cmd.Parameters.AddWithValue("@NewNgaysinh", newNgaysinh);
            cmd.Connection = sqlConnection;

            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Succeed");
                showListNhanVien();
            }
            else
            {
                MessageBox.Show("Unsucceed");
            }
        }
        //delete NhanVien
        private void deleteNhanVien(string manv)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(strConnection);
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "Delete_NHANVIEN";
            sqlcmd.Parameters.AddWithValue("@MNV", tbMANV.Text);
            sqlcmd.Connection = sqlConnection;
            object kq = sqlcmd.ExecuteScalar();
            
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

        private void updateNhanVien_Load(object sender, EventArgs e)
        {
            showListNhanVien();
        }

        private void lvDSNV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lvDSNV.SelectedItems.Count == 0) return;

            ListViewItem lv = lvDSNV.SelectedItems[0];
            manv = lv.SubItems[0].Text.Trim();
            tbMANV.Text = lv.SubItems[0].Text;
            tbHoten.Text = lv.SubItems[1].Text;
            cbChucVu.Text = lv.SubItems[2].Text;
           dtNgaysinh.Text= lv.SubItems[3].Text;
        }

        private void btUpdate_Click_1(object sender, EventArgs e)
        {
            newManv = tbMANV.Text; newHoten = tbHoten.Text; newChucvu = cbChucVu.Text;
            newNgaysinh = DateTime.Parse(dtNgaysinh.Value.ToShortDateString());

            if (((tbMANV.Text == Space(tbMANV.Text.Length) || tbHoten.Text == Space(tbHoten.Text.Length) || cbChucVu.Items.Count == 0) && (lvDSNV.SelectedItems.Count > 0)))
            {
                MessageBox.Show("Chỉ được nhập form không được chọn danh sách trên bảng!!");
                return;
            }
            else
            {
                addNhanVien(newManv, newHoten, newChucvu, newNgaysinh);
                tbMANV.Clear(); tbHoten.Clear(); cbChucVu.Text = "";
            }
        }

        private void btDelete_Click_1(object sender, EventArgs e)
        {
            if (lvDSNV.SelectedItems.Count < 0)
            {
                MessageBox.Show("Please select table!!");
            }
            else
            {
                deleteNhanVien(manv);
                showListNhanVien();
                tbMANV.Clear(); tbHoten.Clear(); cbChucVu.Text = "";

            }
        }
        #endregion


    }
}
