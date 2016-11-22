using System;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new frmSearch();
            f.ShowDialog();
        }

        private void btnCheckInOut_Click(object sender, EventArgs e)
        {
            var f = new frmLending();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f = new frmReg();
            f.ShowDialog();
        }
    }
}
