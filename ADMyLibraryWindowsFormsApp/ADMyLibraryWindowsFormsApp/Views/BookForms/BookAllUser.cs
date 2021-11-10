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
    public partial class BookAllUser : Form
    {
        Users user;
        public BookAllUser(Users _user)
        {
            InitializeComponent();
            user = _user;
        }

        MyLibraryContext db = new MyLibraryContext();
        private void btnBack_Click(object sender, EventArgs e)
        {
            UserPanel frm = new UserPanel(user);
            frm.Show();
            this.Hide();
        }

        private void BookAllUser_Load(object sender, EventArgs e)
        {
            dgwBookList.DataSource = db.Books.Where(b => b.IsActive == true && b.StockAmount > 0).ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = db.Categories.Where(c => c.IsActive == true).ToList();
            lstMyBooks.DisplayMember = "Name";



        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilen = cmbCategory.SelectedItem as Categories;
            dgwBookList.DataSource = secilen.Books.ToList();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string aranankitap = txtFindBook.Text;
            var aranan = db.Books.FirstOrDefault(b => b.Name == aranankitap) as Books;
            if (aranan != null)
            {
                dgwBookList.DataSource = db.Books.Where(b => b.Name == aranan.Name).ToList();
            }
            else
            {
                MessageBox.Show("Kitap Bulunmamakta.");
            }



        }
        List<Books> myBookList = new List<Books>();
        private void dgwBookList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            var secilen = dgwBookList.SelectedRows[0].DataBoundItem as Books;
            if (secilen.StockAmount > 0)
            {
                if (myBookList.Contains(secilen) != true)
                {
                    myBookList.Add(secilen);
                    lstMyBooks.Items.Add(secilen);
                }
                else
                {
                    MessageBox.Show("Kitap Listenizde Bulunmakta");
                }

            }
            else
            {
                MessageBox.Show("Kitap stoğu şuanda bulunmamakta.");
            }
           
        }

        private void lstMyBooks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var secilen = lstMyBooks.SelectedItem as Books;
            myBookList.Remove(secilen);
            lstMyBooks.Items.Remove(secilen);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (myBookList.Count > 0)
            {

                foreach (var item in myBookList)
                {
                    if (item.StockAmount > 0)
                    {
                        Deposits deposit = new Deposits();
                        deposit.UserId = user.UserId;
                        deposit.BookId = item.BookId;
                        deposit.RegisterDate = DateTime.Now;
                        deposit.DeliveryDate = DateTime.Now.AddDays(15);
                        TimeSpan kalangun = (TimeSpan)(deposit.DeliveryDate - deposit.RegisterDate);//Sonucu zaman olarak döndürür
                        double toplamGun = kalangun.TotalDays;// kalanGun den TotalDays ile sadece toplam gun değerini çekiyoruz.
                        if (toplamGun > 15)
                        {
                            deposit.Fine = 0.50f * (toplamGun - 15);
                            deposit.IsActive = true;
                        }
                        else
                        {
                            deposit.Fine = 0f;
                            deposit.IsActive = false;
                        }

                        db.Deposits.Add(deposit);
                        item.StockAmount--;

                    }
                  

                }
            }
            db.SaveChanges();
            

        }
    }
}
