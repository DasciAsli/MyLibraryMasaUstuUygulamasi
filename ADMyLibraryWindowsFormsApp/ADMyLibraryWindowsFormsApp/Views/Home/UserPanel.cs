using ADMyLibraryWindowsFormsApp.Models.EntityFramework;
using ADMyLibraryWindowsFormsApp.Views.BookForms;
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
    public partial class UserPanel : Form
    {
        Users user;
        public UserPanel(Users _user)
        {
            InitializeComponent();
            user = _user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (user.Roles.Count == 2)
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
        private void UserPanel_Load(object sender, EventArgs e)
        {
            lblKullanici.Text = " Hoşgeldin " + user.Name;
        }

        private void btnFineList_Click(object sender, EventArgs e)
        {
            DepositAllUser frm = new DepositAllUser(user);
            frm.Show();
            this.Hide();
        }

        private void btnOperations_Click(object sender, EventArgs e)
        {
            UserEditUser frm = new UserEditUser(user);
            frm.Show();
            this.Hide();

        }

        private void btnBookList_Click(object sender, EventArgs e)
        {
            BookAllUser frm = new BookAllUser(user);
            frm.Show();
            this.Hide();
        }
    }
}
