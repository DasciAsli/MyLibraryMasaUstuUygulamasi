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
    public partial class UserAllAdmin : Form
    {
        Users user;
        public UserAllAdmin(Users _user)
        {
            InitializeComponent();
            user = _user;
        }
        MyLibraryContext db = new MyLibraryContext();
        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPanel frm = new AdminPanel(user);
            frm.Show();
            this.Hide();
        }

        private void UserAllAdmin_Load(object sender, EventArgs e)
        {
            dgwUserList.DataSource = db.Users.ToList();
        }

        private void dgwUserList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            var secilen = dgwUserList.SelectedRows[0].DataBoundItem as Users;
            txtName.Text = secilen.Name;
            txtSurname.Text = secilen.SurName;
            txtEmail.Text = secilen.Email;
            txtPassword.Text = secilen.Password;
            if (secilen.IsActive == true)
            {
                chkDurum.Checked = true;
            }
            else
            {
                chkDurum.Checked = false;
            }
            txtTcNo.Text = secilen.UserDetails.TcNo;
            txtPhone.Text = secilen.UserDetails.Phone;
            if (secilen.UserDetails.Gender == true)
            {
                rdbWoman.Checked = true;
            }
            else
            {
                rdbMan.Checked = true;
            }
            dtpBirthDte.Value = secilen.UserDetails.BirthDate.Value;
            if (secilen.Roles.Count==2)
            {
                chkAdmin.Checked = true;
                chkUser.Checked = true;
            }
            else if (secilen.Roles.Count ==1)
            {
                foreach (var item in secilen.Roles)
                {

                    if (item.RolId == 1)
                    {
                        chkAdmin.Checked = true;
                        chkUser.Checked = false;

                    }
                    else if (item.RolId == 2)
                    {
                        chkUser.Checked = true;
                        chkAdmin.Checked = false;


                    }

                }

            }
            else if (secilen.Roles.Count == 0)
            {
                chkUser.Checked = false;
                chkAdmin.Checked = false;
            }
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (db.Users.FirstOrDefault(u => u.Name == txtName.Text && u.UserDetails.TcNo == txtTcNo.Text) == null)
            {
                Users userx = new Users();
                userx.Name = txtName.Text;
                userx.SurName = txtSurname.Text;
                userx.Email = txtEmail.Text;
                userx.Password = txtPassword.Text;
                userx.RegisterDate = DateTime.Now;
                if (chkDurum.Checked == true)
                {
                    userx.IsActive = true;
                }
                UserDetails detail = new UserDetails();
                detail.TcNo = txtTcNo.Text;
                detail.Phone = txtPhone.Text;
                if (chkDurum.Checked == true)
                {
                    detail.Gender = true;
                }
                else
                {
                    detail.Gender = false;
                }
                detail.BirthDate = dtpBirthDte.Value;
                if (chkAdmin.Checked == true)
                {
                    foreach (var item in db.Roles)
                    {
                        if (item.RolId == 1)
                        {
                            userx.Roles.Add(item);
                        }
                    }

                }
                else
                {

                    foreach (var item in db.Roles)
                    {
                        if (item.RolId == 2)
                        {
                            userx.Roles.Add(item);
                        }
                    }

                }

                userx.UserDetails = detail;

                db.Users.Add(userx);
                db.SaveChanges();
                dgwUserList.DataSource = db.Users.ToList();

            }
            else
            {
                MessageBox.Show("Kullanıcının Kaydı Bulunmaktadır");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var secilen = dgwUserList.SelectedRows[0].DataBoundItem as Users;
            secilen.Name = txtName.Text;
            secilen.SurName = txtSurname.Text;
            secilen.Email = txtEmail.Text;
            secilen.Password = txtPassword.Text;
            secilen.RegisterDate = DateTime.Now;
            if (chkDurum.Checked == true)
            {
                secilen.IsActive = true;
            }
            else
            {
                secilen.IsActive = false;
            }
            secilen.UserDetails.TcNo = txtTcNo.Text;
            secilen.UserDetails.Phone = txtPhone.Text;
            if (rdbWoman.Checked == true)
            {
                secilen.UserDetails.Gender = true;
            }
            else
            {
                secilen.UserDetails.Gender = false;
            }
            secilen.UserDetails.BirthDate = dtpBirthDte.Value;
            if (chkAdmin.Checked == true && chkUser.Checked == false)
            {
                if (secilen.Roles.Count == 2)
                {
                    foreach (var item in db.Roles)
                    {
                        if (item.RolId == 2)
                        {
                            secilen.Roles.Remove(item);

                        }

                    }

                }
                else
                {

                    foreach (var item in db.Roles)
                    {
                        if (secilen.Roles != item)
                        {
                            secilen.Roles.Remove(item);
                            foreach (var item2 in db.Roles)
                            {
                                if (item2.RolId==1)
                                {
                                    secilen.Roles.Add(item2);
                                }

                            }
                            

                        }

                    }
                }

            }
            else if (chkAdmin.Checked == true && chkUser.Checked == true)
            {
                foreach (var item in db.Roles)
                {
                    if (secilen.Roles != item)
                    {
                        secilen.Roles.Add(item);
                    }

                }

            }
            else if (chkAdmin.Checked == false && chkUser.Checked == false)
            {
                foreach (var item in db.Roles)
                {
                    secilen.Roles.Remove(item);
                    MessageBox.Show("Kullanıcıya rol verilmezse kullanı giriş yapamaz");
                }

            }
            else if (chkAdmin.Checked == false && chkUser.Checked == true)
            {
                if (secilen.Roles.Count == 2)
                {
                    foreach (var item in db.Roles)
                    {
                        if (item.RolId == 1)
                        {
                            secilen.Roles.Remove(item);

                        }

                    }

                }
                else
                {

                    foreach (var item in db.Roles)
                    {
                        if (secilen.Roles != item)
                        {
                            secilen.Roles.Remove(item);
                            foreach (var item2 in db.Roles)
                            {
                                if (item2.RolId == 2)
                                {
                                    secilen.Roles.Add(item2);
                                }

                            }


                        }

                    }
                }

            }

            db.SaveChanges();
            dgwUserList.DataSource = db.Users.ToList();
        }
    }
}
