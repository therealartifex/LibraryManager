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
            if (txtAddress.Text == "" || txtFirst.Text == "" || txtLast.Text == "")
                MessageBox.Show("One or more fields are blank.");
            else
            {
                var r = chxMember.Checked ? 1 : 2;
                var db = new libmanDataClassesDataContext();
                var p = new Patron
                {
                    Address = txtAddress.Text,
                    FirstName = txtFirst.Text,
                    LastName = txtLast.Text,
                    Role = r
                };
                db.Patrons.InsertOnSubmit(p);
                db.SubmitChanges();
                if (r == 1)
                {
                    var f=new Fee {Amount = 25m, AssessedDate = DateTime.Today, FeeType = "MEM", PaidDate = DateTime.Today, PatronId = p.Id};
                    db.Fees.InsertOnSubmit(f);
                    db.SubmitChanges();
                }
                MessageBox.Show("Patron registered.");
            }
        }
    }
}
