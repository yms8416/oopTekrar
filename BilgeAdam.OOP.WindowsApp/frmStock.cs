using BilgeAdam.OOP.StockManagement.Helpers;
using BilgeAdam.OOP.StockManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.OOP.WindowsApp
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
            Products = new BindingList<ProductBase>
            {
                new Carpet{ Name = "Atlas", Price = 150, UnitsInStock = 17 },
                new Book{ Name = "Zaman Yönetimi", Price = 45, UnitsInStock = 7 },
                new Computer{ Name = "Lenovo", Price = 4590, UnitsInStock = 25 },
                new Phone{ Name = "iPhone", Price = 3200, UnitsInStock = 5 },
                new Tablet{ Name = "iPad", Price = 2990, UnitsInStock = 12 },
                new Carpet{ Name = "Koyunlu", Price = 200, UnitsInStock = 75 },
                new Phone{ Name = "Samsung S9 Plus", Price = 5850, UnitsInStock = 8 },
                new Book{ Name = "Kaşağı", Price = 20, UnitsInStock = 25 },
                new Book{ Name = "Sefiller", Price = 45, UnitsInStock = 25 },
                new Computer{ Name = "Lenovo", Price = 2500, UnitsInStock = 72 },
            };
        }
        private BindingList<ProductBase> Products { get; }
        private ProductBase selectedItem;
        public ProductBase SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                prgProduct.SelectedObject = selectedItem;
                btnSell.Enabled = btnAddToStock.Enabled = true;
            }
        }
        private void frmStock_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = Products;
            cmbType.DataSource = GetProductTypes();
            btnAddToStock.Enabled = false;
            btnSell.Enabled = false;
            dgvProducts.ClearSelection();
        }
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var selected = dgvProducts.SelectedRows[0].DataBoundItem as ProductBase;// DataBoundItem'ı ProductBase e çevir
            if (selected != null)
            {
                SelectedItem = selected; 
            }
        }

        private List<string> GetProductTypes()
        {
            var list = Enum.GetNames(typeof(ProductType)).ToList();
            return list;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var selected = cmbType.SelectedItem.ToString();
            ProductType pt;
            Enum.TryParse(selected, out pt);

            SelectedItem = ProductHelper.GetProduct(pt);
            //ürün tipine (pt) göre class ı çağır
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Products.Add(SelectedItem); 
            SelectedItem = null;
        }

        private void prgProduct_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            //2147982877

            //long a = 5;
            //int b = (int)a;

            //int c = 8;
            //long d = c;

            var oldValue = (int)e.OldValue;
            var newValue = (int)e.ChangedItem.Value;
            var diff = newValue - oldValue;
            //TODO: doğrudan erişerek de yapılabilir
        }

        private void btnAddToStock_Click(object sender, EventArgs e)
        {
            var pm = new ProductManager<ProductBase>(SelectedItem);
            pm.AddToStock((int)nudAmount.Value);
            RefreshControls();
        }
        private void btnSell_Click(object sender, EventArgs e)
        {
            var pm = new ProductManager<ProductBase>(SelectedItem);
            pm.Sell((int)nudAmount.Value);
            RefreshControls();
        }
        private void RefreshControls()
        {
            dgvProducts.Refresh();
            prgProduct.Refresh();
            //daha fazla kod
        }
    }
}
