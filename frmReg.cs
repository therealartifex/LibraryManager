using System;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class frmReg : Form
    {
        public frmReg()
        {
            InitializeComponent();
        }

        private void frmReg_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtFirst.Text == "" || txtLast.Text == "") MessageBox.Show("One or more fields are blank.");
            else
            {
                // do things
            }
        }
    }
}
