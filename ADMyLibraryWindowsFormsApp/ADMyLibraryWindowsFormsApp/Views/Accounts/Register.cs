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

namespace ADMyLibraryWindowsFormsApp.Views
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        MyLibraryContext db = new MyLibraryContext();
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Yeni bir user nesnesi oluşturup içi dolduruldu.
            Users user = new Users();
            user.Name = txtName.Text;
            user.SurName = txtSurname.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.RegisterDate = DateTime.Now;
            user.IsActive = true;

            //detail nesnesi oluşturuldu.
            UserDetails detail = new UserDetails();
            detail.TcNo = txtTcNo.Text;
            detail.Phone = txtPhone.Text;
            if (rdbWoman.Checked== true)
            {
                detail.Gender = true;
            }
            else
            {
                detail.Gender = false;
            }
            detail.BirthDate = dtpBirthdate.Value;

            //usera admin rolü eklendi.
            foreach (var item in db.Roles)
            {
                if (item.RolId == 1)
                {
                    user.Roles.Add(item);
                }
            }

            //detail nesnesinin verilerini yeni oluşturdugumuz userin UserDetailsine eşitledik.
            user.UserDetails = detail;
            //Oluşturduğumuz userı database tablomuza ekledik
            db.Users.Add(user);
            //databasedeki değişiklikleri kaydettik
            db.SaveChanges();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
