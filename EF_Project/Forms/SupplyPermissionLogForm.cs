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
    public partial class SupplyPermissionLogForm : Form
    {
        public SupplyPermissionLogForm()
        {
            InitializeComponent();
        }
        ModelContext context = new ModelContext();
        SupplyPermissionLog supplypermissionLog = new SupplyPermissionLog();
        #region Functions
        private SupplyPermissionLog GetSupplyPermissionLogById(int id) => context.SupplyPermissionLogs.Find(id);
        private SupplyPermissionLog FillData()
        {
            var sup = context.Suppliers.FirstOrDefault(i => i.Name==supplierComboBox.Text);
            int suppPerId = int.Parse(suppPercomboBox.Text);
            var supPerm = context.SupplyPermissions.FirstOrDefault(i => i.SerialNum == suppPerId);
            var prod = context.Products.FirstOrDefault(i => i.Name==productComboBox.Text);
            supplypermissionLog.Quantity     = quantityTextBox.Text;
            supplypermissionLog.Fk_ProductID = prod.ProductId;
            supplypermissionLog.Fk_SupplyPermissionId = supPerm.SupplyPermissionId;
            supplypermissionLog.Fk_SupplierID = sup.SupplierId;
            supplypermissionLog.ProductionDate = productionDateTime.Value;
            supplypermissionLog.ExpireDat = expireDateTime.Value;
            return supplypermissionLog;
        }
        private SupplyPermissionLog UpdateData(SupplyPermissionLog supPerLog)
        {
            var sup = context.Suppliers.FirstOrDefault(i => i.Name == supplierComboBox.Text);
            int suppPerId = int.Parse(suppPercomboBox.Text);
            var supPerm = context.SupplyPermissions.FirstOrDefault(i => i.SerialNum == suppPerId);
            var prod = context.Products.FirstOrDefault(i => i.Name == productComboBox.Text);
            supPerLog.Quantity = quantityTextBox.Text;
            supPerLog.Fk_ProductID = prod.ProductId;
            supPerLog.Fk_SupplyPermissionId = supPerm.SupplyPermissionId;
            supPerLog.Fk_SupplierID = sup.SupplierId;
            supPerLog.ProductionDate = productionDateTime.Value;
            supPerLog.ExpireDat = expireDateTime.Value;
            return supPerLog;
        }

        private void ClearBoxes()
        {
            quantityTextBox.Text = "";
            expireDateTime.Value = DateTime.Now;
            productionDateTime.Value = DateTime.Now;

        }
        private List<SupplyPermissionLog> GetSupplyPermissionLogsList()=> context.SupplyPermissionLogs.ToList();
        private List<Product> GetProductsList() => context.Products.ToList();
        private List<SupplyPermission> GetSupplyPermissionsList()=>context.SupplyPermissions.ToList();
        private List<Supplier> GetSuppliersList()=>context.Suppliers.ToList();
        #endregion
        private void SupplyPermissionLogForm_Load(object sender, EventArgs e)
        {      
            foreach (var item in GetSupplyPermissionLogsList())
            {
                idComboBox.Items.Add(item.SupplyPermissionLogId);
            }
            foreach (var item in GetProductsList())
            {
                productComboBox.Items.Add(item.Name);
            }
            foreach (var item in GetSuppliersList())
            {
                supplierComboBox.Items.Add(item.Name);
            }
            foreach (var item in GetSupplyPermissionsList())
            {
                suppPercomboBox.Items.Add(item.SerialNum);
            }
            productionDateTime.Value = DateTime.Now;
        }

        
        private void idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = int.Parse(idComboBox.Text);

            SupplyPermissionLog spLog = GetSupplyPermissionLogById(id);
            var sup= context.Suppliers.FirstOrDefault(i => i.SupplierId == spLog.Fk_SupplierID);
            var supPerm = context.SupplyPermissions.FirstOrDefault(i => i.SupplyPermissionId == spLog.Fk_SupplyPermissionId);
            var prod = context.Products.FirstOrDefault(i => i.ProductId == spLog.Fk_ProductID);
            quantityTextBox.Text = spLog.Quantity;
            supplierComboBox.SelectedItem = sup.Name;
            suppPercomboBox.SelectedItem = supPerm.SerialNum;
            productComboBox.SelectedItem = prod.Name;
            productionDateTime.Text = spLog.ProductionDate.ToString();
            expireDateTime.Text = spLog.ExpireDat.ToString();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            var supplyPerLog = GetSupplyPermissionLogsList();
            var supplir = GetSuppliersList();
            var supPerm = GetSupplyPermissionsList();
            var prod = GetProductsList();
            var show = from spl in supplyPerLog
                        join p in prod on spl.Fk_ProductID equals p.ProductId
                        join sp in supPerm on spl.Fk_SupplyPermissionId equals sp.SupplyPermissionId
                        join su in supplir on spl.Fk_SupplierID equals su.SupplierId
                        select new
                        {
                            spl.SupplyPermissionLogId,
                            spl.Quantity,
                            Product_Name = p.Name,
                            spl.ExpireDat,
                            Supplier_Name = su.Name,
                            Serial_SupplyPerm=sp.SerialNum,
                            spl.ProductionDate
                        };
           // var show = context.SupplyPermissionLogs.Select(s => new { s.SupplyPermissionLogId, s.Quantity
            //    , s.Fk_ProductID, s.ExpireDat,s.Fk_SupplierID,s.Fk_SupplyPermissionId,s.ProductionDate }).ToList();
            suppPerLogDataGridView.DataSource = show.ToList();
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
                        context.SupplyPermissionLogs.Add(FillData());
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (quantityTextBox.Text == "" || idComboBox.SelectedItem == null)
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
                    SupplyPermissionLog spLog = context.SupplyPermissionLogs.Find(id);             
                    context.SupplyPermissionLogs.AddOrUpdate(UpdateData(spLog));
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
