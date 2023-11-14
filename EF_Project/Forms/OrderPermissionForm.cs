using Microsoft.Win32;
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
    public partial class OrderPermissionForm : Form
    {
        public OrderPermissionForm()
        {
            InitializeComponent();
        }
        ModelContext context = new ModelContext();
        Order order = new Order();
        #region HelpFuncs
        private Store GetStore(int id)
        {
            return context.Stores.FirstOrDefault(m => m.StoreID == id);
        }
        private List<Store> GetStoreList()
        {
            return context.Stores.ToList();
        }
        private List<Customer> GetCustomerList() => context.Customers.ToList();
        private bool IsUniqueCode(string num)
        {
            var serial = context.Orders.FirstOrDefault(n => n.SerialNum == num);
            if (serial != null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
       
        private Order FillData(string serial)
        {
            var name = (storeIDComboBox.Text);
            var custName = customerCmboBox.Text;
            Store store = context.Stores.FirstOrDefault(s => s.Name == name);
            Customer cust = context.Customers.FirstOrDefault(c => c.Name == custName);
            order.SerialNum = serial;
            order.Date = dateTimePicker.Value;
            order.Fk_StoreID = store.StoreID;
            order.Fk_CustomerID = cust.CustomerId;
            return order;
        }
        #endregion
        private void OrderPermissionForm_Load(object sender, EventArgs e)
        {
            var orderPer = context.Orders.ToList();
            foreach (var item in orderPer)
            {
                idComboBox.Items.Add(item.OrderID);
            }
            var storeID = GetStoreList();
            foreach (var item in storeID)
            {
                storeIDComboBox.Items.Add(item.Name);
            }
            var CustomerList = GetCustomerList();
            foreach (var item in CustomerList)
            {
                customerCmboBox.Items.Add(item.Name);
            }
            dateTimePicker.Value = DateTime.Now;
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            var store = GetStoreList();
            var cust = GetCustomerList();
            var order = context.Orders.ToList();
            var show = from ordr in order
                        join st in store on ordr.Fk_StoreID equals st.StoreID
                        join c in cust on ordr.Fk_CustomerID equals c.CustomerId
                        select new
                        {
                            ordr.OrderID,
                            ordr.SerialNum,
                            ordr.Date,
                            Customer_Name =c.Name,
                            Store_Name = st.Name
                        };
            //var show = context.Orders.Select(s => new { s.OrderID, s.SerialNum, s.Date, s.Fk_StoreID }).ToList();
            orderDataGridView.DataSource = show.ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
         
            if (serialTextBox.Text == "" || idComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please Enter at Least ID & Serial Number");
            }
            else
            {
                string serial = serialTextBox.Text;
                if (IsUniqueCode(serial) == true)
                {
                    FillData(serial);
                    context.Orders.Add(order);
                    context.SaveChanges();
                    MessageBox.Show("Saved");
                    serialTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Please Enter Unique Serial Num");
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (serialTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Serial Number");
            }
            else
            {
                string serial = serialTextBox.Text;
                if (IsUniqueCode(serial) == true)
                {
                    var id = int.Parse(idComboBox.Text);
                    Order order = context.Orders.Find(id);
                    order.OrderID = id;
                    FillData(serial);
                    context.Orders.AddOrUpdate(order);
                    context.SaveChanges();
                    MessageBox.Show("Updated");
                    serialTextBox.Text = "";

                }
                else
                {
                    MessageBox.Show("Please Enter Unique Serial Number");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = int.Parse(idComboBox.Text);
            var orderId = context.Orders.First(i => i.OrderID == id);
            var store =GetStore(orderId.OrderID);
            serialTextBox.Text=orderId.SerialNum.ToString();
            storeIDComboBox.SelectedItem = store.Name;
            var cust = context.Customers.FirstOrDefault(i => i.CustomerId == orderId.Fk_CustomerID);
            customerCmboBox.SelectedItem = cust.Name;
            dateTimePicker.Value = orderId.Date.Value;
        }
    }
}

