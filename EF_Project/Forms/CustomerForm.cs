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

namespace EF_Project.Forms
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        ModelContext context = new ModelContext();
        Customer customer = new Customer();
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            var show = context.Customers.Select(s => new { s.Name, s.CustomerId, s.Phone, s.Mail, s.Fax, s.URL, s.Mobile }).ToList();
            supplierDataGridView.DataSource = show;
        }

        private void idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = int.Parse(idComboBox.Text);
            Customer c = context.Customers.Find(id);
            nameTextBox.Text = c.Name;
            phoneTextBox.Text = c.Phone == null ? "" : c.Phone.ToString();
            mobileTextBox.Text = c.Mobile == null ? "" : c.Mobile.ToString();
            faxTextBox.Text = c.Fax == null ? "" : c.Mobile.ToString();
            urlTextBox.Text = c.URL == null ? "" : c.URL.ToString();
            mailTextBox.Text = c.Mail == null ? "" : c.Mail.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || mobileTextBox.Text == "")
            {
                MessageBox.Show("Please Enter at least Name or Mobile");
            }
            else
            {
                customer.Name = nameTextBox.Text;
                customer.Phone= int.Parse(phoneTextBox.Text);
                customer.Mobile = int.Parse(mobileTextBox.Text);
                customer.Fax = int.Parse(faxTextBox.Text);
                customer.URL = (urlTextBox.Text);
                customer.Mail = mailTextBox.Text;
                context.Customers.Add(customer);
                context.SaveChanges();
                MessageBox.Show("Saved");
                nameTextBox.Text = phoneTextBox.Text = mobileTextBox.Text =
                faxTextBox.Text = urlTextBox.Text = mailTextBox.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || mobileTextBox.Text == "")
            {
                MessageBox.Show("Please Enter at least Name or Mobile");
            }
            else
            {
                var id = int.Parse(idComboBox.Text);
                Customer customerId = context.Customers.FirstOrDefault(s => s.CustomerId == id);
                customer.CustomerId =customerId.CustomerId;
                customer.Name = nameTextBox.Text;
                customer.Phone = int.Parse(phoneTextBox.Text);
                customer.Mobile = int.Parse(mobileTextBox.Text);
                customer.Fax = int.Parse(faxTextBox.Text);
                customer.URL = (urlTextBox.Text);
                customer.Mail = mailTextBox.Text;
                context.Customers.AddOrUpdate(customer);
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

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            var cusId = context.Customers.ToList();
            foreach (var item in cusId)
            {
                idComboBox.Items.Add(item.CustomerId);
            }
        }
    }
}
