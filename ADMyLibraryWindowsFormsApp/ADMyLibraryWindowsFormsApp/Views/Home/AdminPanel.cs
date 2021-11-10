
using ADMyLibraryWindowsFormsApp.Models.EntityFramework;
using ADMyLibraryWindowsFormsApp.Views.BookForms;
using ADMyLibraryWindowsFormsApp.Views.CategoryForms;
using ADMyLibraryWindowsFormsApp.Views.DepositForms;
using ADMyLibraryWindowsFormsApp.Views.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMyLibraryWindowsFormsApp.Views.Home
{
    public partial class AdminPanel : Form
    {
        Users user;
        public AdminPanel(Users _user)
        {
            InitializeComponent();
            user = _user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (user.Roles.Count==2)
            {
                AdminUserPanel frm = new AdminUserPanel(user);
                frm.Show();
                this.Hide();
            }
            else
            {
                Login frm = new Login();
                frm.Show();
                this.Hide();
            }
            
        }

        private void btnBookList_Click(object sender, EventArgs e)
        {
            BookAllAdmin frm = new BookAllAdmin(user);
            frm.Show();
            this.Hide();
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            Category frm = new Category(user);
            frm.Show();
            this.Hide();
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            UserAllAdmin frm = new UserAllAdmin(user);
            frm.Show();
            this.Hide();
        }

        private void btnFineList_Click(object sender, EventArgs e)
        {
            DepositEditAdmin frm = new DepositEditAdmin(user);
            frm.Show();
            this.Hide();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            lblKullanici.Text = " Hoşgeldin " + user.Name;
        }
    }
}
