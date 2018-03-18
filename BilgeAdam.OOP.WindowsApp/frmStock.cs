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
            Products = new List<ProductBase>
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
        private List<ProductBase> Products { get; }
        public ProductBase SelectedItem { get; set; }
        private void frmStock_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = Products;
            cmbType.DataSource = GetProductTypes();
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
                prgProduct.SelectedObject = selected; 
            }
        }

        private List<string> GetProductTypes()
        {
            var list = Enum.GetNames(typeof(ProductType)).ToList();
            return list;
        }
    }
}
