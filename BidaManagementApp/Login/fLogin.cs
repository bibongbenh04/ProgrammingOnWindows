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

namespace BidaManagementApp.Login
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            txtWrongLogin.Visible = false;

        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkLogin()
        {
            if (txtUserName.Text == "admin" && txtPassWord.Text == "admin")
            {
                txtWrongLogin.Visible = false;
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                txtWrongLogin.Visible = true;
                txtPassWord.Clear();
            }
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            checkLogin();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                // Xử lý dữ liệu khi nhấn Enter trên form
                checkLogin();
                return true; // Ngăn ngừa sự kiện mặc định của nút Enter
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
