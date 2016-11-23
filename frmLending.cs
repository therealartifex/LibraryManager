using System;
using System.Linq;
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
            txtStatus.AppendText($"{DateTime.Now}\n- - - - - - - - - -\n");
            if (txtBookId.Text == "" || txtPatronId.Text == "") txtStatus.AppendText("Book ID and Patron ID cannot be empty.\n");
            else
            {
                var db = new libmanDataClassesDataContext();
                var bookOut = db.Lendings.Any(l => l.BookId == int.Parse(txtBookId.Text) && l.ReturnDate == null);
                var booksChecked = db.Lendings.Count(l => l.PatronId == int.Parse(txtPatronId.Text));
                var limit = db.Patrons.Where(p => p.Id == int.Parse(txtPatronId.Text)).Select(p => p.Role1.Limit).First();
                var chargesPending = db.Fees.Where(f => f.PatronId == int.Parse(txtPatronId.Text) && f.PaidDate==null);
                var totalFees = chargesPending.Select(f => f.Amount).Sum();
                if (bookOut) txtStatus.AppendText("Book has been checked out already.\n");
                else if (booksChecked==limit) txtStatus.AppendText("Checkout limit reached.\n");
                else if (totalFees > 0)
                {
                    var mb = MessageBox.Show($"Patron has ${totalFees} in charges which must be paid before further checkouts are made. Pay now?","LibMan", MessageBoxButtons.YesNo);
                    if (mb == DialogResult.Yes)
                    {
                        foreach (var cp in chargesPending) cp.PaidDate = DateTime.Today;
                        db.SubmitChanges();
                    }
                }
                else
                {
                    var checkout = new Lending
                    {
                        BookId = int.Parse(txtBookId.Text),
                        PatronId = int.Parse(txtPatronId.Text),
                        BorrowDate = DateTime.Today
                    };
                    db.Lendings.InsertOnSubmit(checkout);
                    txtStatus.AppendText("Patron successfully checked out book.\n");
                    db.SubmitChanges();
                }
            }
        }

        private void btnCI_Click(object sender, EventArgs e)
        {
            txtStatus.Clear();
            txtStatus.AppendText($"{DateTime.Now}\r\n- - - - - - - - - -");
            if (txtBookId.Text == "") txtStatus.AppendText("Book ID cannot be empty.\n");
            else
            {
                var db = new libmanDataClassesDataContext();
                var bookOut = db.Lendings.Any(l => l.BookId == int.Parse(txtBookId.Text) && l.ReturnDate == null);
                if (!bookOut) txtStatus.AppendText("Book has not been checked out.\n");
                else
                {
                    var dateOut = db.Lendings.Where(l => l.BookId == int.Parse(txtBookId.Text) && l.ReturnDate==null).Select(l => l.BorrowDate).First();
                    if ((DateTime.Today - dateOut).TotalDays > 7)
                    {
                        var p = db.Lendings.Where(l => l.BookId == int.Parse(txtBookId.Text) && l.ReturnDate==null).Select(l => l.PatronId).First();
                        var f = new Fee { Amount = 5m, AssessedDate = DateTime.Today, FeeType = "OD", PatronId = p };
                        var mb = MessageBox.Show($"Patron has returned book overdue. Pay now?", "LibMan", MessageBoxButtons.YesNo);
                        if (mb == DialogResult.Yes) f.PaidDate = DateTime.Today;
                        db.Fees.InsertOnSubmit(f);
                    }
                    var checkin = db.Lendings.First(l => l.BookId == int.Parse(txtBookId.Text) && l.ReturnDate==null);
                    checkin.ReturnDate = DateTime.Today;
                    txtStatus.AppendText($"CHECK IN\r\nPATRON: {checkin.Patron.LastName}, {checkin.Patron.FirstName}\r\nBOOK: {checkin.Book.Title}\r\n");

                }
                db.SubmitChanges();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
