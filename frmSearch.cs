using System.Windows.Forms;

namespace LibraryManager
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Search field is blank.");
            else
            {
                // do things
            }
        }
    }
}
