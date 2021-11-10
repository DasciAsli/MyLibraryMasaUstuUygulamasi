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

namespace ADMyLibraryWindowsFormsApp.Views.UserForms
{
    public partial class UserEditUser : Form
    {
        Users user;
        public UserEditUser(Users _user)
        {
            InitializeComponent();
            user = _user;
        }
        MyLibraryContext db = new MyLibraryContext();
        private void btnBack_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            UserPanel frm = new UserPanel(user);
            frm.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var userx = db.Users.Find(user.UserId);
            userx.Name = txtName.Text;
            userx.SurName = txtSurName.Text;
            userx.Email = txtEmail.Text;
            userx.Password = txtPssword.Text;
            if (rdbWoman.Checked== true)
            {
                userx.UserDetails.Gender = true;
            }
            else
            {
                userx.UserDetails.Gender = false;
            }
            userx.RegisterDate = DateTime.Now;
            userx.UserDetails.TcNo = txtTcNo.Text;
            userx.UserDetails.Phone = txtPhone.Text;
            db.SaveChanges();
            MessageBox.Show("Değişiklikler kaydedildi");

        }

        private void UserEditUser_Load(object sender, EventArgs e)
        {
            txtName.Text =user.Name;
            txtSurName.Text = user.SurName;
            txtEmail.Text = user.Email;
            txtPssword.Text = user.Password;
            if (user.UserDetails.Gender== true)
            {
                rdbWoman.Checked = true;
            }
            else
            {
                rdbMan.Checked = true;
            }
            txtTcNo.Text = user.UserDetails.TcNo;
            txtPhone.Text = user.UserDetails.Phone;
            dtpBirthDate.Value = user.UserDetails.BirthDate.Value;
            
        }
    }
}
