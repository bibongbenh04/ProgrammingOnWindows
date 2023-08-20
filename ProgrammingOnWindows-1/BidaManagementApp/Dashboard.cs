using BidaManagementApp.All_UserControl;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btAddBan_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btAddBan.Left = 50;
            aC_Billiard1.Visible = true;
            aC_Billiard1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            aC_Billiard1.Visible=false;
            btAddBan.PerformClick();
        }
    }
}
