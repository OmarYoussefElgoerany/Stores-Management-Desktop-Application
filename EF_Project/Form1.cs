using EF_Project.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EF_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ModelContext context = new ModelContext();
        SupplyPermission sp = new SupplyPermission();
        #region Functions
        private List<Transfer> GetTransferList() => context.Transfers.ToList();
        private List<Supplier> GetSuppliersList() => context.Suppliers.ToList();

        private Transfer GetTransferById(int id) => context.Transfers.FirstOrDefault(i => i.TransferID == id);

        private SupplyPermissionLog GetSupplyPermissionLogById(int id) => context.SupplyPermissionLogs.Find(id);
        private List<SupplyPermissionLog> GetSupplyPermissionLogList() => context.SupplyPermissionLogs.ToList();
        private List<SupplyPermission> GetSupplyPermissionList() => context.SupplyPermissions.ToList();
                private List<Product> GetProductsList() => context.Products.ToList();

        private List<Product> GetProdList()
        {
            return context.Products.ToList();
        }
        private List<Store> GetStoreList() => context.Stores.ToList();
        #endregion
        private void store_Click(object sender, EventArgs e)
        {
            StoreForm store = new StoreForm();
            store.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formDateTimePicker.Value=DateTime.Now;
            var sp = "Supply Permission";
            var op = "Order Permission";
            foreach (var item in GetStoreList())
            {
                storecomboBox.Items.Add(item.Name);
                storeTransfercomboBox.Items.Add(item.Name);

            }
            var getSuppPerm = context.SupplyPermissions.ToList();
            permComboBox.Items.Add(sp);
            permComboBox.Items.Add(op);
            var prod = context.Products.ToList();
            foreach (var item in prod)
            {
                prodComboBox.Items.Add(item.Name);
                productCmboBxExpire.Items.Add(item.Name);
            }
        }

        private void product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
        }

        private void MenuSupplier_Click(object sender, EventArgs e)
        {
            SupplierForm supplier = new SupplierForm();
            supplier.Show();
        }

        private void menuCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customer = new CustomerForm();
            customer.Show();
        }

        private void supplyPermissionMenu_Click(object sender, EventArgs e)
        {
            SupplyPermissionForm supplyPermissionForm = new SupplyPermissionForm();
            supplyPermissionForm.Show();

        }

        private void orrderPermissionMenu_Click(object sender, EventArgs e)
        {
            OrderPermissionForm orderPermissionForm = new OrderPermissionForm();
            orderPermissionForm.Show();
        }

        private void supplyPermissionLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplyPermissionLogForm supplyPermissionLogForm = new SupplyPermissionLogForm();
            supplyPermissionLogForm.Show();
        }

        private void orderPermissionLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderPermissionLogForm orderLogForm = new OrderPermissionLogForm();
            orderLogForm.Show();
        }

        private void transferMenuItem_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm();
            transferForm.Show();
        }

      

        private void btnShowEachStore_Click(object sender, EventArgs e)
        {
                var selectEdStore = storecomboBox.Text;
                var getStoreByNme = context.Stores.FirstOrDefault(s => s.Name == selectEdStore);
            var storeid = context.Stores.FirstOrDefault(i => i.Name == store.Name);
            if(permComboBox.Text==""|| storecomboBox.Text=="")
            {
                MessageBox.Show("Select Items");
            }
            if (permComboBox.SelectedIndex == 0)
            {
                var store = GetStoreList();
                var supplyPerm = context.SupplyPermissions.ToList();
                var filtr = context.SupplyPermissions.
                    Where(i => i.Fk_StoreID == getStoreByNme.StoreID).Include(a=>a.Store).
                    Select(a=>new
                    {
                        a.SupplyPermissionId,
                        a.SerialNum,
                        a.date,
                        Store_Name= a.Store.Name
                    });
                dataGridView1.DataSource = filtr.ToList();
            }
            else
            {
                var orderPerm = context.Orders.ToList();
                var filterOrd = context.Orders.Where(i => i.Fk_StoreID == getStoreByNme.StoreID)
                    .Include(a => a.Store).Select(a => new
                    {
                        a.OrderID,
                        a.SerialNum,
                        a.Date,
                        Store_Name = a.Store.Name
                    });
                dataGridView1.DataSource = filterOrd.ToList();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            var store = GetStoreList();
            var supplyPerm = context.SupplyPermissions.ToList();
            if (permComboBox.SelectedIndex == 0||storecomboBox.Text == "")
            {
                var showw = (from supp in supplyPerm
                             join st in store
                             on supp.Fk_StoreID equals st.StoreID
                             select new
                             {
                                 supp.SupplyPermissionId,
                                 supp.SerialNum,
                                 supp.date,
                                 Store_Name = st.Name
                             });
                dataGridView1.DataSource = showw.ToList();
            }
            else
            {
                var selectEdStore = storecomboBox.Text;
                var getStoreByNme = context.Stores.FirstOrDefault(s => s.Name == selectEdStore);
                var orderPerm = context.Orders.ToList();
                var filterOrd = context.Orders
                    .Include(a => a.Store).Select(a => new
                    {
                        a.OrderID,
                        a.SerialNum,
                        a.Date,
                        Store_Name = a.Store.Name
                    });
                dataGridView1.DataSource = filterOrd.ToList();
            }
           
        }

        private void btnShowProd_Click(object sender, EventArgs e)
        {
            if (prodComboBox.Text == "")
            {
                MessageBox.Show("At Least Enter Prod", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var supPerm = GetSupplyPermissionList();
                var prod = GetProductsList();
                var supplyPerLog = GetSupplyPermissionLogList();
                var show = (from spl in supplyPerLog
                           join p in prod on spl.Fk_ProductID equals p.ProductId
                           join sp in supPerm on spl.Fk_SupplyPermissionId equals sp.SupplyPermissionId
                           select new
                           {
                               Product_Name = p.Name,
                               p.Code,
                               spl.ProductionDate,
                               spl.ExpireDat,
                               spl.Quantity,
                               Store_ID=sp.Fk_StoreID,
                           });
                var filter = show.Where(p=>p.Product_Name==prodComboBox.Text).ToList();
                dataGridView1.DataSource = filter;

            }
        }

        private void btnShowAllProd_Click(object sender, EventArgs e)
        {
            if (prodComboBox.Text == "")
            {
                MessageBox.Show("At Least Enter Prod", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var supPerm = GetSupplyPermissionList();
                var prod = GetProductsList();
                var supplyPerLog = GetSupplyPermissionLogList();
                var show = from spl in supplyPerLog
                           join p in prod on spl.Fk_ProductID equals p.ProductId
                           join sp in supPerm on spl.Fk_SupplyPermissionId equals sp.SupplyPermissionId
                           select new
                           {
                               Product_Name = p.Name,
                               p.Code,
                               spl.ProductionDate,
                               spl.ExpireDat,
                               spl.Quantity,
                               Store_ID = sp.Fk_StoreID,
                           };
                dataGridView1.DataSource = show.ToList();
            }
        }

        private void btnShowDate_Click(object sender, EventArgs e)
        {

            var prodDate = context.SupplyPermissionLogs.FirstOrDefault();
            prodDate.ProductionDate = proddateTime.Value;
            var date = proddateTime.Value;


            if (prodComboBox.Text == "")
            {
                MessageBox.Show("At Least Enter Prod", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (proddateTime.Value >= date || proddateTime.Value <= date)
                {
                    var supPerm = GetSupplyPermissionList();
                    var prod = GetProductsList();
                    var supplyPerLog = GetSupplyPermissionLogList();
                    var show = (from spl in supplyPerLog
                                join p in prod on spl.Fk_ProductID equals p.ProductId
                                join sp in supPerm on spl.Fk_SupplyPermissionId equals sp.SupplyPermissionId
                                select new
                                {
                                    Product_Name = p.Name,
                                    p.Code,
                                    spl.ProductionDate,
                                    spl.ExpireDat,
                                    spl.Quantity,
                                    Store_ID = sp.Fk_StoreID,
                                });
                    var filter = show.Where(p => p.Product_Name == prodComboBox.Text)
                        .Where(i => i.ProductionDate == date).ToList();
                    dataGridView1.DataSource = filter;
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnShowAllTrns_Click(object sender, EventArgs e)
        {
            if (storeTransfercomboBox.Text != "")
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
                dataGridView1.DataSource = show.ToList();
            }
            else
            {
                MessageBox.Show("At Least Add Store", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
       
        }

        private void btnShowTrns_Click(object sender, EventArgs e)
        {
            if (storeTransfercomboBox.Text != "")
            {
                var storeTras=context.Stores.FirstOrDefault(i=>i.Name==storeTransfercomboBox.Text);
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
                var filter = show.Where(i => i.From_Store == storeTras.Name);
                dataGridView1.DataSource = filter.ToList();
            }
            else
            {
                MessageBox.Show("At Least Add Store", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnShowDteTrans_Click(object sender, EventArgs e)
        {

            var transDate = context.Transfers.FirstOrDefault();
            transDate.ProductionDate = proddateTime.Value;
            var date= transferDateTime.Value;
            if (storeTransfercomboBox.Text != "")
            {
                if (proddateTime.Value >= date || proddateTime.Value <= date)
                {
                    var storeTras = context.Stores.FirstOrDefault(i => i.Name == storeTransfercomboBox.Text);
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
                                   Production_Date =t.ProductionDate,
                                   Expire_Date= t.ExpireDate,
                                   Product_Name = p.Name,
                                   Supplier_Name = s.Name,
                                   From_Store = frm.Name,
                                   To_Store = to.Name
                               };
                    var filter = show.Where(i => i.From_Store == storecomboBox.Text).Where(i => i.Production_Date == date);
                    dataGridView1.DataSource = filter.ToList();
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Date","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("At Least Add Store","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

  


        private void btnShowExpire_Click(object sender, EventArgs e)
        { 

            if (productCmboBxExpire.Text == "")
            {
                var getTrans = context.Transfers.ToList();
                var getSuppLog = GetSupplyPermissionLogList();
                var getProd = GetProdList();
                var show = from supl in getSuppLog
                           join p in getProd on supl.Fk_ProductID equals p.ProductId
                           select new
                           {
                               Product_Name = p.Name,
                               Expiration_Date = supl.ExpireDat
                           };
                var expire = expireDateTime.Value;
                var filter = show.Where(i => i.Expiration_Date == expire);
                dataGridView1.DataSource = filter.ToList();
            }
            else
            {
                MessageBox.Show("At Least Choose Product and Valid Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (productCmboBxExpire.Text == "")
            {
                var getTrans = context.Transfers.ToList();
                var getSuppLog = GetSupplyPermissionLogList();
                var getProd = GetProdList();
                var show = from supl in getSuppLog
                           join p in getProd on supl.Fk_ProductID equals p.ProductId
                           select new
                           {
                               Product_Name = p.Name,
                               Expiration_Date = supl.ExpireDat
                           };
                dataGridView1.DataSource = show.ToList();
            }
            else
            {
                MessageBox.Show("At Least Choose Product and Valid Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
