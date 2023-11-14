using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EF_Project.Forms
{
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }
        ModelContext context = new ModelContext();
        Supplier supplier= new Supplier();

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            var supId = context.Suppliers.ToList();
            foreach (var item in supId)
            {
                idComboBox.Items.Add(item.SupplierId);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            var show = context.Suppliers.Select(s => new { s.Name, s.SupplierId, s.Phone, s.Mail,s.Fax,s.URL,s.Mobile }).ToList();
            supplierDataGridView.DataSource = show;
        }

        private void idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = int.Parse(idComboBox.Text);
            Supplier s = context.Suppliers.Find(id);
            nameTextBox.Text   = s.Name;
            phoneTextBox.Text  = s.Phone== null ? "": s.Phone.ToString();
            mobileTextBox.Text = s.Mobile == null?"" : s.Mobile.ToString();
            faxTextBox.Text    = s.Fax == null ? "" : s.Mobile.ToString();
            urlTextBox.Text     = s.URL == null ?"":s.URL.ToString();
            mailTextBox.Text    = s.Mail == null ? "" : s.Mail.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            if (nameTextBox.Text == "" || mobileTextBox.Text =="")
            {
                MessageBox.Show("Please Enter at least Name or Mobile");
            }
            else
            {
                supplier.Name = nameTextBox.Text;
                supplier.Phone =int.Parse(phoneTextBox.Text);
                supplier.Mobile =int.Parse(mobileTextBox.Text);
                supplier.Fax = int.Parse(faxTextBox.Text);
                supplier.URL = (urlTextBox.Text);
                supplier.Mail = mailTextBox.Text;
                context.Suppliers.Add(supplier);
                context.SaveChanges();
                MessageBox.Show("Saved");
                nameTextBox.Text = phoneTextBox.Text = mobileTextBox.Text =
                 faxTextBox.Text = urlTextBox.Text = mailTextBox.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || mobileTextBox.Text == "" || idComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please Enter at least ID or Name or Mobile");
            }
            else
            {
                var id = int.Parse(idComboBox.Text);
                var supplierId = context.Suppliers.FirstOrDefault(s => s.SupplierId == id);
                supplier.SupplierId = supplierId.SupplierId;
                supplier.Name = nameTextBox.Text;
                supplier.Phone = int.Parse(phoneTextBox.Text);
                supplier.Mobile = int.Parse(mobileTextBox.Text);
                supplier.Fax = int.Parse(faxTextBox.Text);
                supplier.URL = (urlTextBox.Text);
                supplier.Mail = mailTextBox.Text;
                context.Suppliers.AddOrUpdate(supplier);
                context.SaveChanges();
                MessageBox.Show("Updated");
                nameTextBox.Text = phoneTextBox.Text = mobileTextBox.Text =
                faxTextBox.Text = urlTextBox.Text = mailTextBox.Text = "";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
