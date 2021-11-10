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

namespace ADMyLibraryWindowsFormsApp.Views.DepositForms
{
    public partial class DepositAllUser : Form
    {
        Users user;
        public DepositAllUser(Users _user)
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

        private void DepositAllUser_Load(object sender, EventArgs e)
        {
            dgwDepositList.DataSource = db.Deposits.Where(d => d.UserId == user.UserId).ToList();
            
        }

        List<Deposits> myDeliverList = new List<Deposits>();
        private void dgwDepositList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var secilen = dgwDepositList.SelectedRows[0].DataBoundItem as Deposits;
            myDeliverList.Add(secilen);
           
            Books bookName = db.Books.Find(secilen.BookId) as Books;
            listBox1.Items.Add(bookName.Name);
            

        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
           
            foreach (var item in myDeliverList)
            {
                if (item.Fine==0)
                {
                    Books book = db.Books.FirstOrDefault(b => b.BookId == item.BookId);
                    int adet = Convert.ToInt32(book.StockAmount);
                    adet++;
                    book.StockAmount = Convert.ToByte(adet);
                    db.Deposits.Remove(item);

                }

                   

            }
            db.SaveChanges();
            dgwDepositList.DataSource = db.Deposits.Where(d => d.UserId == user.UserId).ToList();
        }
    }
}
