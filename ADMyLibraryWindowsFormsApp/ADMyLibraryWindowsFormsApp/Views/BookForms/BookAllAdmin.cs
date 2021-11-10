using ADMyLibraryWindowsFormsApp.Models.EntityFramework;
using ADMyLibraryWindowsFormsApp.Views.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMyLibraryWindowsFormsApp.Views.BookForms
{
    public partial class BookAllAdmin : Form
    {
        Users user;
        public BookAllAdmin(Users _user)
        {
            InitializeComponent();
            user = _user;
        }

        MyLibraryContext db = new MyLibraryContext();
        
        private void BookAllAdmin_Load(object sender, EventArgs e)
        {
            dgwBookList.DataSource = db.Books.Where(b => b.IsActive == true).ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = db.Categories.Where(c => c.IsActive == true).ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPanel frm = new AdminPanel(user);
            frm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var kontrol = db.Books.FirstOrDefault(b => b.Name == txtName.Text && b.Writer == txtWriter.Text);
            if (kontrol == null)
            {
                Books book = new Books();
                book.Name = txtName.Text;
                book.Writer = txtWriter.Text;
                book.Page = Convert.ToByte(txtPage.Text);
                book.DateOfIssue = dtpDateOfIssue.Value;
                book.RegisterDate = DateTime.Now;
                if (chkDurum.Checked == true)
                {
                    book.IsActive = true;
                }
                if (book.StockAmount != null)
                {
                    book.StockAmount++;
                }
                else if (book.StockAmount == null)
                {
                    book.StockAmount = 1;
                }

                Categories secilen = cmbCategory.SelectedItem as Categories;
                book.Categories.Add(secilen);
                db.Books.Add(book);
                db.SaveChanges();
                dgwBookList.DataSource = db.Books.Where(b => b.IsActive == true).ToList();

            }
            else
            {
                kontrol.StockAmount++;
                db.SaveChanges();
                dgwBookList.DataSource = db.Books.Where(b => b.IsActive == true).ToList();
            }
        }

        private void dgwBookList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var secilen = dgwBookList.SelectedRows[0].DataBoundItem as Books;
            txtName.Text = secilen.Name;
            txtWriter.Text = secilen.Writer;
            txtPage.Text = Convert.ToString(secilen.Page);
            foreach (var item in db.Categories)
            {
                if (item == secilen.Categories)
                {
                    cmbCategory.Text = item.Name;
                }
            }
            dtpDateOfIssue.Value = secilen.DateOfIssue.Value;
            if (secilen.IsActive== true)
            {
                chkDurum.Checked = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var secilen = dgwBookList.SelectedRows[0].DataBoundItem as Books;
            secilen.Name = txtName.Text;
            secilen.Writer = txtWriter.Text;
            secilen.Page = Convert.ToByte(txtPage.Text);
            secilen.DateOfIssue = dtpDateOfIssue.Value;
            secilen.RegisterDate = DateTime.Now;
            if (chkDurum.Checked== true)
            {
                secilen.IsActive = true;
            }
            else
            {
                secilen.IsActive = false;
            }
            db.SaveChanges();
            dgwBookList.DataSource = db.Books.Where(b => b.IsActive == true).ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var secilen = dgwBookList.SelectedRows[0].DataBoundItem as Books;
            if (secilen.StockAmount > 1)
            {
                secilen.StockAmount--;
            }
            else
            {
                db.Books.Remove(secilen);
            }
            db.SaveChanges();
            dgwBookList.DataSource = db.Books.Where(b => b.IsActive == true).ToList();

        }
    }
}
