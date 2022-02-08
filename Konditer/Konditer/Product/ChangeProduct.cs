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
    public partial class ChangeProduct : Form
    {
        PastryShopEntities db = new PastryShopEntities();
        int id;

        public ChangeProduct(int idProd, string name, decimal priceProd, double masaPr)
        {
            InitializeComponent();
            id = idProd;
            nametxt.Text = name;
            MasaTxt.Text = Convert.ToString(masaPr);
            txtPrice.Text = Convert.ToString(priceProd);
        }

        private void ChangeIng_Load(object sender, EventArgs e)
        {
      
        }

        private void ProviderButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (nametxt.Text != "" && txtPrice.Text != "" && MasaTxt.Text != "")
                {
                    Product product = db.Product.Where(p => p.IdProduct == id).FirstOrDefault();
                product.Name = nametxt.Text;
                product.Price = Convert.ToDecimal(txtPrice.Text);
                product.Masa = Convert.ToDouble(MasaTxt.Text);
                db.SaveChanges();
                MessageBox.Show("Вы успешно обновили данные о продукте!");
                this.Close();
                ProductForm productForm = new ProductForm();
                productForm.ProductTable();
                productForm.Visible = true;
                productForm.ShowInTaskbar = true;
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new CompositionForm(id).Show();
            this.ShowInTaskbar = false;
        }
    }
}
