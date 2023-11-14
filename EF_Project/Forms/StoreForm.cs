using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EF_Project
{
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();
        }
        ModelContext context = new ModelContext();
        Store store = new Store();
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            var store = context.Stores.ToList();
            var manger=context.EmployeeMangers.ToList();
            var s= (from st in store 
                    join emp in manger
                   on st.EmployeManger equals emp.Id  //innerKey
                   select new
                   {
                       st.StoreID,
                       st.Name,
                       st.Address,
                       Manger=emp.Name
                   }).ToList();
            //var show = context.Stores.Select(s => new { s.StoreID, s.Name, s.Address, s.EmployeManger }).ToList();
            storeDataGridView.DataSource=s ;         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(NametextBox.Text == "" ||  NametextBox.Text =="" || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please Enter Full Data","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                store.Name = NametextBox.Text;
                store.Address = addressTextBox.Text;
                var mangerId = context.EmployeeMangers.FirstOrDefault(s => s.Name == (comboBox1.Text));
                store.EmployeManger = mangerId.Id;
                context.Stores.Add(store);
                context.SaveChanges();
                MessageBox.Show("Saved");
            }
        }

        private void StoreForm_Load(object sender, EventArgs e)
        {
            var mang = context.EmployeeMangers.ToList();
            foreach (var item in mang)
            {
                comboBox1.Items.Add(item.Name);
            }
            var idQurey = context.Stores.ToList();
            foreach (var item in idQurey)
            {
                comboBox2.Items.Add(item.StoreID);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text =="" || NametextBox.Text == "")
            {
                MessageBox.Show("Please Enter Full Data");
            }
            else
            {
                var mangerId = context.EmployeeMangers.FirstOrDefault(s => s.Name == (comboBox1.Text));
                store.EmployeManger = mangerId.Id;
                store.Name = NametextBox.Text;
                store.Address = addressTextBox.Text;
                store.StoreID = int.Parse(comboBox2.Text);
                context.Stores.AddOrUpdate(store);
                context.SaveChanges();
                MessageBox.Show($"Updated");
                NametextBox.Text = addressTextBox.Text = "";
            }
            
            }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = int.Parse(comboBox2.Text);
            Store s = context.Stores.Find(id);
            NametextBox.Text = s.Name;
            addressTextBox.Text = s.Address;
            var manger = context.EmployeeMangers.FirstOrDefault(m => m.Id == s.EmployeManger);
            comboBox1.SelectedItem =manger.Name;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }
    }

      
  }

