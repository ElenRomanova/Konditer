using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konditer
{
    public partial class ProductForm : Form
    {
        PastryShopEntities db = new PastryShopEntities();
        int id;
        string name;
        decimal price;
        double masa;
        public ProductForm()
        {
            InitializeComponent();
        }
        public void ProductTable()
        {
            TableProduct.DataSource = db.Product.ToList();
            TableProduct.Columns[0].Visible = false;
            TableProduct.Columns[4].Visible = false;
            TableProduct.Columns[1].HeaderText = "Наименовение";
            TableProduct.Columns[2].HeaderText = "Цена";
            TableProduct.Columns[3].HeaderText = "Вес";

            id = Convert.ToInt32(TableProduct[0, 0].Value);

        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            this.Close();
            MineMenu mineMenu = new MineMenu();
            mineMenu.Show();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ProductTable();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new CreateProduct().Show();
            this.ShowInTaskbar = false;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить данный продукт?", null, MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Product productDel = db.Product.Where(p => p.IdProduct == id).FirstOrDefault();
                db.Product.Remove(productDel);
                db.SaveChanges();
                ProductTable();
            }
        }

        private void TableProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(TableProduct[0, e.RowIndex].Value);
                 name = Convert.ToString(TableProduct[1, e.RowIndex].Value);
                 price = Convert.ToDecimal(TableProduct[2, e.RowIndex].Value);
                 masa = Convert.ToDouble(TableProduct[3, e.RowIndex].Value);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new ChangeProduct(id,name, price, masa).Show();
            this.ShowInTaskbar = false;
        }

        private void PanelProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnComposition_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new CompositionForm(id).Show();
            this.ShowInTaskbar = false;
        }
    }
}
