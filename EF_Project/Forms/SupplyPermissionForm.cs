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
    public partial class SupplyPermissionForm : Form
    {
        public SupplyPermissionForm()
        {
            InitializeComponent();
        }
        ModelContext context = new ModelContext();
        SupplyPermission supplypermission = new SupplyPermission();

        private Store GetStore(int id)
        {
            return context.Stores.FirstOrDefault(m => m.StoreID == id);
        }
        private List<Store> GetStoreList()
        {
            return context.Stores.ToList();
        }

        private void idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = int.Parse(idComboBox.Text);
            SupplyPermission sp = context.SupplyPermissions.Find(id);
            serialTextBox.Text = sp.SerialNum.ToString();
            var storeId = context.Stores.FirstOrDefault(m => m.StoreID == sp.Fk_StoreID);
            storeIDComboBox.SelectedItem = storeId.Name;
            dateTimePicker.Text = sp.date.ToString();

        }

        private void SupplyPermissionForm_Load(object sender, EventArgs e)
        {
            var supplyPerm = context.SupplyPermissions.ToList();
            foreach (var item in supplyPerm)
            {
                idComboBox.Items.Add(item.SupplyPermissionId);
            }
            var storeID = GetStoreList();
            foreach (var item in storeID)
            {
                storeIDComboBox.Items.Add(item.Name);
            }
            dateTimePicker.Value = DateTime.Now;
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            var store = GetStoreList();
            var supplyPerm = context.SupplyPermissions.ToList();
            var show = from supp in supplyPerm
                        join st in store
                        on supp.Fk_StoreID equals st.StoreID
                        select new
                        {
                            supp.SupplyPermissionId,
                            supp.SerialNum,
                            supp.date,
                            Store_Name =st.Name
                        };

            //var show = context.SupplyPermissions.Select(s => new { s.SupplyPermissionId, s.SerialNum, s.date, s.Fk_StoreID }).ToList();
            supplyDataGridView.DataSource = show.ToList();
        }
        private bool IsUniqueCode(int num)
        {
            var serial = context.SupplyPermissions.FirstOrDefault(n => n.SerialNum == num);
            if (serial != null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (serialTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Serial Number","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                serialTextBox.Focus();
            }
            else
            {
                var isNumeric = int.TryParse((serialTextBox.Text), out int result);
                int serial = result;
                if (IsUniqueCode(serial) == true)
                {
                    var name = (storeIDComboBox.Text);
                    Store store = context.Stores.FirstOrDefault(s => s.Name == name);
                    supplypermission.SerialNum = serial;
                    supplypermission.date = dateTimePicker.Value;
                    supplypermission.Fk_StoreID = store.StoreID;
                    context.SupplyPermissions.Add(supplypermission);
                    context.SaveChanges();
                    MessageBox.Show("Saved");
                    serialTextBox.Text = "";
                    idComboBox.Items.Clear();
                    storeIDComboBox.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Please Enter Unique Code");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (serialTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Full Data");
            }
            else
            {
                var isNumeric = int.TryParse((serialTextBox.Text), out int result);
                int serial = result;
                if (IsUniqueCode(serial) == true)
                {
                    var id = int.Parse(idComboBox.Text);
                    SupplyPermission sp = context.SupplyPermissions.Find(id);
                    supplypermission.SerialNum = serial;
                    supplypermission.date = dateTimePicker.Value;
                    supplypermission.Fk_StoreID = sp.Fk_StoreID;
                    supplypermission.SupplyPermissionId = int.Parse(idComboBox.Text);
                    context.SupplyPermissions.AddOrUpdate(supplypermission);
                    context.SaveChanges();
                    MessageBox.Show("Updated");


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

      
    }
}
