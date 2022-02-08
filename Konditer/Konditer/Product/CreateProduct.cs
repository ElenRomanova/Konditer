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
    public partial class CreateProduct : Form
    {
        int id;
        PastryShopEntities db = new PastryShopEntities();
        public CreateProduct()
        {
            InitializeComponent();
        }
        string name;

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "" && txtPrice.Text != "" && txtMasa.Text != "")
                {
                    int price;
                    float Masa;
                    name = txtName.Text;
                    price = Convert.ToInt32(txtPrice.Text);
                    Masa = float.Parse(txtMasa.Text);


                    Product product = new Product { Name = name, Price = price, Masa = Masa };
                    db.Product.Add(product);
                    db.SaveChanges();
                    id = product.IdProduct;
                    MessageBox.Show("Вы успешно добавили продукт!");

                    ProductForm prod = new ProductForm();
                    //prod.Visible = true;
                    prod.ProductTable();
                    //this.ShowInTaskbar = false;
                    //this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ProductForm product = new ProductForm();
            product.ShowInTaskbar = true;
            product.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            this.Close();
            AddIng addIng = new AddIng(id);
            addIng.ShowInTaskbar = true;
            addIng.Visible = true;
        }
    }
}
