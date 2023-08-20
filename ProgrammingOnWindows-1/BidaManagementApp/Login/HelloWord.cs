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
    public partial class HelloWord : Form
    {
        public HelloWord()
        {
            InitializeComponent();
            timer1.Start();
        }


        private void HelloWord_Load(object sender, EventArgs e)
        {
           
        }

        private int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(++i == 3)
            {
                DataTable dt = new DataTable();
                dt = DataProvider.Instance.ExecuteQuery("SELECT 1");
                this.Hide();
                fLogin fLogin = new fLogin();
                fLogin.ShowDialog();
                this.Close();
                timer1.Stop();
            }
        }
    }
}
