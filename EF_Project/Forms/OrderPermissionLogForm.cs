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
    public partial class OrderPermissionLogForm : Form
    {
        public OrderPermissionLogForm()
        {
            InitializeComponent();
        }
        ModelContext context = new ModelContext();
        OrderLog orderLog = new OrderLog();
        #region Functions
        private OrderLog GetOrderLogById(int id) => context.OrderLogs.Find(id);

        private OrderLog FillData()
        {
            var sup = context.Suppliers.FirstOrDefault(i => i.Name == supplierComboBox.Text);
            var prod = context.Products.FirstOrDefault(i => i.Name == productComboBox.Text);
            var order = context.Orders.FirstOrDefault(i => i.SerialNum == orderComboBox.Text);
            orderLog.Quantity = quantityTextBox.Text;
            orderLog.Date = dateTime.Value;
            orderLog.Fk_ProductID = prod.ProductId;
            orderLog.Fk_SupplierID = sup.SupplierId;
            orderLog.Fk_OrderID = order.OrderID;
            return orderLog;
        }
        private OrderLog UpdateData(OrderLog orderLg)
        {
            //orderlogID quantity date supplierid orderid productid
            var sup = context.Suppliers.FirstOrDefault(i => i.Name == supplierComboBox.Text);
            var prod = context.Products.FirstOrDefault(i => i.Name == productComboBox.Text);
            var order = context.Orders.FirstOrDefault(i => i.SerialNum == orderComboBox.Text);
            orderLg.Quantity = quantityTextBox.Text;
            orderLg.Date = dateTime.Value;
            orderLg.Fk_ProductID = prod.ProductId;
            orderLg.Fk_SupplierID = sup.SupplierId;
            orderLg.Fk_OrderID = order.OrderID;
            return orderLg;
        }
        private void ClearBoxes()
        {
            quantityTextBox.Text = "";
            dateTime.Value = DateTime.Now;

        }
        private List<OrderLog> GetOrderLogsList() => context.OrderLogs.ToList();
        private List<Product> GetProductsList() => context.Products.ToList();
        private List<Supplier> GetSuppliersList() => context.Suppliers.ToList();
        private List<Order> GetOrderList() => context.Orders.ToList();

        #endregion

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            var ordrLog = GetOrderLogsList();
            var supplir = GetSuppliersList();
            var prod = GetProductsList();
            var order = GetOrderList();
            var show = from oL in ordrLog
                        join su in supplir on oL.Fk_SupplierID equals su.SupplierId
                        join p in prod on oL.Fk_ProductID equals p.ProductId
                        join o in order on oL.Fk_OrderID equals o.OrderID
                        select new
                        {
                            oL.OrderLogID,
                            oL.Quantity,
                            Product_Name= p.Name,
                            Supplier_Name = su.Name,
                            Order_Serial=o.SerialNum,
                            oL.Date
                        };
            //var show = context.OrderLogs.Select(o => new {
            //    o.OrderLogID,
            //    o.Quantity,
            //    o.Fk_ProductID,
            //    o.Fk_SupplierID,
            //    o.Fk_OrderID,
            //    o.Date
            //}).ToList();
            orderDataGridView.DataSource = show.ToList();
        }

        private void idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = int.Parse(idComboBox.Text);
            OrderLog orderLog = GetOrderLogById(id);
            var sup = context.Suppliers.FirstOrDefault(i => i.SupplierId == orderLog.Fk_SupplierID);
            var prod = context.Products.FirstOrDefault(i => i.ProductId == orderLog.Fk_ProductID);
            var order =context.Orders.FirstOrDefault(i=>i.OrderID== orderLog.Fk_OrderID);
            quantityTextBox.Text = orderLog.Quantity;
            supplierComboBox.SelectedItem = sup.Name;
            orderComboBox.SelectedItem = order.SerialNum;
            productComboBox.SelectedItem = prod.Name;
            dateTime.Text = order.Date.ToString();
        }

        private void OrderPermissionLog_Load(object sender, EventArgs e)
        {
            foreach (var item in GetProductsList())
            {
                productComboBox.Items.Add(item.Name);
            }
            foreach (var item in GetSuppliersList())
            {
                supplierComboBox.Items.Add(item.Name);
            }
            foreach (var item in GetOrderList())
            {
                orderComboBox.Items.Add(item.SerialNum);
            }
            foreach (var item in GetOrderLogsList())
            {
                idComboBox.Items.Add(item.OrderLogID);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (quantityTextBox.Text == ""|| idComboBox.SelectedItem==null)
            {
                MessageBox.Show("Please Enter At Least ID and Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                quantityTextBox.Focus();
            }
            else
            {
                
                var isNumeric = int.TryParse((quantityTextBox.Text), out int result);
                if (isNumeric == true)
                {
                    var id = int.Parse(idComboBox.Text);
                    OrderLog orderLg = context.OrderLogs.Find(id);
                    context.OrderLogs.AddOrUpdate(UpdateData(orderLg));
                    context.SaveChanges();
                    ClearBoxes();
                    MessageBox.Show("Updated");
                }
                else
                {
                    MessageBox.Show("Please Enter Quntity Number");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (quantityTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                quantityTextBox.Focus();
            }
            else
            {
                var isNumeric = int.TryParse((quantityTextBox.Text), out int result);
                if (isNumeric == true)
                {
                    context.OrderLogs.Add(FillData());
                    context.SaveChanges();
                    ClearBoxes();
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Please Enter Quantity Number");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
