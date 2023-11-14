using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace EF_Project.Forms
{
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
        }
        ModelContext context = new ModelContext();
        Transfer transfer = new Transfer();
        #region Functions
        private List<Supplier> GetSuppliersList() => context.Suppliers.ToList();
        private List<Product> GetProductsList() => context.Products.ToList();
        private List<Transfer> GetTransferList() => context.Transfers.ToList();
        private Transfer FillData()
        {
            
            var sup = context.Suppliers.FirstOrDefault(i => i.Name == supplierComboBox.Text);
            var prod = context.Products.FirstOrDefault(i => i.Name == productComboBox.Text);
            var frmStore = context.Stores.FirstOrDefault(i=> i.Name==fromStorecomboBox.Text);
            var toStore = context.Stores.FirstOrDefault(i => i.Name == toStoreComboBox.Text);
            transfer.Quantity = quantityTextBox.Text;
            transfer.ProductionDate = productionDateTime.Value;
            transfer.ExpireDate = expireDateTime.Value;
            transfer.Fk_FromStoreID = frmStore.StoreID;
            transfer.Fk_ToStoreID = toStore.StoreID;
            transfer.Fk_SupplierID = sup.SupplierId;
            transfer.Fk_ProductID = prod.ProductId;
            return transfer;
        }
        private Transfer UpdateData(Transfer trans)
        {
            var sup = context.Suppliers.FirstOrDefault(i => i.Name == supplierComboBox.Text);
            var prod = context.Products.FirstOrDefault(i => i.Name == productComboBox.Text);
            var frmStore = context.Stores.FirstOrDefault(i => i.Name == fromStorecomboBox.Text);
            var toStore = context.Stores.FirstOrDefault(i => i.Name == toStoreComboBox.Text);
            trans.Quantity = quantityTextBox.Text;
            trans.ProductionDate = productionDateTime.Value;
            trans.ExpireDate = expireDateTime.Value;
            trans.Fk_FromStoreID = frmStore.StoreID;
            trans.Fk_ToStoreID = toStore.StoreID;
            trans.Fk_SupplierID = sup.SupplierId;
            trans.Fk_ProductID = prod.ProductId;
            return trans;
        }

        private Transfer GetTransferById(int id) => context.Transfers.FirstOrDefault(i => i.TransferID == id);
        #endregion
        private void TransferForm_Load(object sender, EventArgs e)
        {
            var store = context.Stores.ToList();
            foreach (var item in GetTransferList())
            {
                idComboBox.Items.Add(item.TransferID);
            }
            foreach (var item in store)
            {
                toStoreComboBox.Items.Add(item.Name);
                fromStorecomboBox.Items.Add(item.Name);
            }
            foreach (var item in GetSuppliersList())
            {
                supplierComboBox.Items.Add(item.Name);
            }
            foreach (var item in GetProductsList())
            {
                productComboBox.Items.Add(item.Name);
            }

        }

        private void idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = int.Parse(idComboBox.Text);
            Transfer transfer = GetTransferById(id);
            var sup = context.Suppliers.FirstOrDefault(i => i.SupplierId == transfer.Fk_SupplierID);
            var prod = context.Products.FirstOrDefault(i => i.ProductId == transfer.Fk_ProductID);
            var store = context.Stores.FirstOrDefault(i => i.StoreID == transfer.Fk_ToStoreID);
            quantityTextBox.Text = transfer.Quantity;
            productionDateTime.Value = transfer.ProductionDate.Value;
            expireDateTime.Value = transfer.ExpireDate.Value;
            fromStorecomboBox.SelectedItem =store.Name;
            toStoreComboBox.SelectedItem = store.Name;
            supplierComboBox.SelectedItem = sup.Name;
            productComboBox.SelectedItem = prod.Name;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            var transfer = GetTransferList();
            var product = GetProductsList();
            var supplier = GetSuppliersList();
            var store = context.Stores.ToList();
            var show = from t in transfer
                       join p in product on t.Fk_ProductID equals p.ProductId
                       join s in supplier on t.Fk_SupplierID equals s.SupplierId
                       join frm in store on t.Fk_FromStoreID equals frm.StoreID
                       join to in store on t.Fk_ToStoreID equals to.StoreID
                       select new
                       {
                           t.TransferID,
                           t.Quantity,
                           t.ProductionDate,
                           t.ExpireDate,
                           Product_Name = p.Name,
                           Supplier_Name = s.Name,
                           From_Store = frm.Name,
                           To_Store = to.Name
                       };
            transferDataGridView.DataSource = show.ToList();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            var frm=fromStorecomboBox.SelectedItem;
            var to = toStoreComboBox.SelectedItem;
            if(frm == to)
            {
                MessageBox.Show("Enter Different Stores", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(quantityTextBox.Text == "")
                {
                    MessageBox.Show("Please Enter Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    quantityTextBox.Focus();
                }
                else
                {
                    context.Transfers.Add(FillData());
                    context.SaveChanges();
                    quantityTextBox.Text = "";
                    MessageBox.Show("Saved");

                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var frm = fromStorecomboBox.SelectedItem;
            var to = toStoreComboBox.SelectedItem;
            if (frm == to)
            {
                MessageBox.Show("Enter Different Stores", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (quantityTextBox.Text == "")
                {
                    MessageBox.Show("Please Enter Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    quantityTextBox.Focus();
                }
                else
                {
                    var getTransId = int.Parse(idComboBox.Text);
                    var getTrans = context.Transfers.Find(getTransId);
                    context.Transfers.Add(UpdateData(getTrans));
                    context.SaveChanges();
                    quantityTextBox.Text = "";
                    MessageBox.Show("Update");
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
