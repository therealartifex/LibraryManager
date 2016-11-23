using System;
using System.Linq;
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
            listView1.Items.Clear();
            if (txtSearch.Text == "") MessageBox.Show("Search field is blank.");
            else
            {
                var db = new libmanDataClassesDataContext();
                var q = db.Books.Where(_=>_.Title.Contains(txtSearch.Text)).Select(_=>new {_.Title,Author=$"{_.AuthorLastName}, {_.AuthorFirstName}"});
                foreach (var b in q) listView1.Items.Add(new ListViewItem(new[] {b.Title,b.Author}));
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                txtStatus.Clear();
                var db = new libmanDataClassesDataContext();
                var b = db.Books.First(_ => _.Title == e.Item.Text);
                txtStatus.AppendText("LENDING STATUS: ");
                Lending l = db.Lendings.FirstOrDefault(_ => _.Book==b && _.ReturnDate == null);
                txtStatus.AppendText(l == null ? "AVAILABLE\r\n" : $"CHECKED OUT\r\nTO: {l.Patron.LastName}, {l.Patron.FirstName}\r\nDUE: {l.BorrowDate+TimeSpan.FromDays(7):d}");
            }
        }
    }
}
