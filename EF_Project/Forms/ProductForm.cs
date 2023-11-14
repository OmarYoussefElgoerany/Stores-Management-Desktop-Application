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

namespace EF_Project
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        ModelContext context = new ModelContext();
        Product product = new Product();

        private void ProductForm_Load(object sender, EventArgs e)
        {
            var prod = context.Products.ToList();
            foreach (var item in prod)
            {
                idComboBox.Items.Add(item.ProductId);
            }
            var unit = context.Units.ToList();
            foreach (var item in unit)
            {
                unitComboBox.Items.Add(item.Name);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (codeTextBox.Text == "" ||  nameTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Full Data");
            }
            else
            {
                var isNumeric = int.TryParse((codeTextBox.Text), out int result);
                int code = result;
                if (IsUniqueCode(code) == true)
                {
                    codeTextBox.Text = code.ToString();
                    product.Name = nameTextBox.Text;
                    product.Code = code;
                    var unit = context.Units.FirstOrDefault(s => s.Name == (unitComboBox.Text));
                    product.Fk_UnitID = unit.UnitID;
                    context.Products.Add(product);
                    context.SaveChanges();
                    MessageBox.Show("Saved");
                    codeTextBox.Text = nameTextBox.Text = "";

                }
                else
                {
                    MessageBox.Show("Please Enter Unique Code");
                }
            }


        }
        private bool IsUniqueCode(int num)
        {
            var code = context.Products.FirstOrDefault(n => n.Code == num);
            if (code != null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            var prod = context.Products.ToList();
            var unit = context.Units.ToList();
            var show = from p in prod
                         join u in unit
                         on p.Fk_UnitID equals u.UnitID
                         select new
                         {
                             p.ProductId,p.Name,p.Code,Unit=u.Name
                         };
            //var show = context.Products.Select(s => new { s.ProductId, s.Name, s.Code, s.Fk_UnitID }).ToList();
            productDataGridView.DataSource = show.ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (codeTextBox.Text == "" || nameTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Full Data");
            }
            else
            {
                var unit = context.Units.FirstOrDefault(s => s.Name == (unitComboBox.Text));
                var isNumeric = int.TryParse((codeTextBox.Text), out int result);
                int code = result;
                if (IsUniqueCode(code) == true)
                {
                    product.ProductId = int.Parse(idComboBox.Text);
                    codeTextBox.Text = code.ToString();
                    product.Name = nameTextBox.Text;
                    product.Code = code;
                    product.Fk_UnitID = unit.UnitID;
                    context.Products.AddOrUpdate(product);
                    context.SaveChanges();
                    MessageBox.Show("Updated");
                    codeTextBox.Text = nameTextBox.Text = "";

                }
                else
                {
                    MessageBox.Show("Please Enter Unique Code");
                }

            }
               
        }

        private void idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = int.Parse(idComboBox.Text);
            Product p = context.Products.Find(id);
            nameTextBox.Text = p.Name;
            codeTextBox.Text = p.Code.ToString();
            var unit = context.Units.FirstOrDefault(m => m.UnitID == p.Fk_UnitID);
            unitComboBox.SelectedItem = unit.Name;
        }
    }
}
