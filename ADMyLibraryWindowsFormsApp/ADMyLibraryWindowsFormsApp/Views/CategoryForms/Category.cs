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

namespace ADMyLibraryWindowsFormsApp.Views.CategoryForms
{
    public partial class Category : Form
    {
        Users user;
        public Category(Users _user)
        {
            InitializeComponent();
            user = _user;
        }
        MyLibraryContext db = new MyLibraryContext();
        private void Category_Load(object sender, EventArgs e)
        {
            dgwCategoryList.DataSource = db.Categories.ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPanel frm = new AdminPanel(user);
            frm.Show();
            this.Hide();
        }

        private void dgwCategoryList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var secilen = dgwCategoryList.SelectedRows[0].DataBoundItem as Categories;
            txtName.Text = secilen.Name;
            if (secilen.IsActive== true)
            {
                chkDurum.Checked = true;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var secilen = dgwCategoryList.SelectedRows[0].DataBoundItem as Categories;
            secilen.Name = txtName.Text;
            if (chkDurum.Checked== true)
            {
                secilen.IsActive = true;
            }
            else
            {
                secilen.IsActive = false;
            }
            secilen.RegisterDate = DateTime.Now;
            db.SaveChanges();
            dgwCategoryList.DataSource = db.Categories.ToList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var secilen = dgwCategoryList.SelectedRows[0].DataBoundItem as Categories;
            db.Categories.Remove(secilen);
            db.SaveChanges();
            dgwCategoryList.DataSource = db.Categories.ToList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (db.Categories.FirstOrDefault(c=> c.Name==txtName.Text) == null)
            {
                Categories category = new Categories();
                category.Name = txtName.Text;
                if (chkDurum.Checked== true)
                {
                    category.IsActive = true;
                }
                else
                {
                    category.IsActive = false;
                }
                category.RegisterDate = DateTime.Now;
                db.Categories.Add(category);
                db.SaveChanges();
                dgwCategoryList.DataSource = db.Categories.ToList();

            }
            else
            {
                MessageBox.Show("Kategori bulunmakta");
            }
        }
    }
}
