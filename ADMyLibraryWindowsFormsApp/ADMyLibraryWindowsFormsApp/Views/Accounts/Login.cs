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

namespace ADMyLibraryWindowsFormsApp.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        MyLibraryContext db = new MyLibraryContext();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            var user = db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                if (user.IsActive == true)
                {
                    if (user.Roles.Count==2)
                    {
                        AdminUserPanel frm = new AdminUserPanel(user);
                        frm.Show();
                        this.Hide();
                    }
                    else if (user.Roles.Count == 1)
                    {
                        foreach (var item in user.Roles)
                        {
                            if (item.RolId == 1)
                            {
                                AdminPanel frm = new AdminPanel(user);
                                frm.Show();
                                this.Hide();
                            }
                            else
                            {
                                UserPanel frm = new UserPanel(user);
                                frm.Show();
                                this.Hide();
                            }
                        }

                    }
                   
                }
                else
                {
                    MessageBox.Show("Kullanıcı aktif değil");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadi");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register frm = new Register();
            frm.Show();
            this.Hide();
        }
    }
}
