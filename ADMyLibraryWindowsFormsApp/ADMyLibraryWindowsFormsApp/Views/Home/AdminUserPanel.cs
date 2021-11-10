using ADMyLibraryWindowsFormsApp.Models.EntityFramework;
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
    public partial class AdminUserPanel : Form
    {
        Users user;
        public AdminUserPanel(Users _user)
        {
            InitializeComponent();
            user = _user;
        }

        private void AdminUserPanel_Load(object sender, EventArgs e)
        {
            lblKullanici.Text = "Hoşgeldin " + user.Name;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanel frm = new AdminPanel(user);
            frm.Show();
            this.Hide();

        }

        private void btnUserPanel_Click(object sender, EventArgs e)
        {
            UserPanel frm = new UserPanel(user);
            frm.Show();
            this.Hide();

        }
    }
}
