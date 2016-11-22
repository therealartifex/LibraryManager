using System;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class frmLending : Form
    {
        public frmLending()
        {
            InitializeComponent();
        }

        private void btnCO_Click(object sender, EventArgs e)
        {
            txtStatus.Clear();
            txtStatus.AppendText($"{DateTime.Now}\n");
            if (txtBookId.Text == "" || txtPatronId.Text == "") txtStatus.AppendText("Book ID and Patron ID cannot be empty.\n");
            else
            {
                // do things
            }
        }

        private void btnCI_Click(object sender, EventArgs e)
        {
            txtStatus.Clear();
            txtStatus.AppendText($"{DateTime.Now}\n");
            if (txtBookId.Text == "") txtStatus.AppendText("Book ID cannot be empty.\n");
            else
            {
                // do things
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
