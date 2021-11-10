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
    public partial class DepositEditAdmin : Form
    {
        Users user;
        public DepositEditAdmin(Users _user)
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
        
        private void DepositEditAdmin_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Deposits)
            {
                TimeSpan kalangun = (TimeSpan)(DateTime.Now - item.DeliveryDate);
                double toplamGun = kalangun.TotalDays;
                if (toplamGun > 15)
                {
                    item.Fine = 0.50f * (toplamGun - 15);
                    item.IsActive = true;
                }
                else
                {
                    item.Fine = 0f;
                    item.IsActive = false;
                }
            }
            db.SaveChanges();
            dgwDepositList.DataSource = db.Deposits.ToList();
           
        }

        private void dgwDepositList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var secilen = dgwDepositList.SelectedRows[0].DataBoundItem as Deposits;
            txtName.Text = secilen.Users.Name;
            txtAmount.Text = Convert.ToString(secilen.Fine);
            dtpRegisterDate.Value = secilen.RegisterDate.Value;
            if (secilen.IsActive== true)
            {
                chkDurum.Checked = true;
            }
            else
            {
                chkDurum.Checked = false;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var secilen = dgwDepositList.SelectedRows[0].DataBoundItem as Deposits;
            secilen.Fine = Convert.ToInt32(txtAmount.Text);
            secilen.RegisterDate = dtpRegisterDate.Value;
            if (chkDurum.Checked== true)
            {
                secilen.IsActive = true;
            }
            else
            {
                secilen.IsActive = false;
            }
            secilen.DeliveryDate = secilen.RegisterDate.Value.AddDays(15);
            db.SaveChanges();
            dgwDepositList.DataSource = db.Deposits.ToList();
        }
    }
}
