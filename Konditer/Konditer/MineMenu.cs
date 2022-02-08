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
    public partial class MineMenu : Form
    {
        public MineMenu()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            //this.Visible = false;
            //this.ShowInTaskbar = false;
            this.Hide();
        }

        private void ProviderButton_Click(object sender, EventArgs e)
        {
            ProviderForm providerForm = new ProviderForm();
            providerForm.Show();
            this.Hide();

        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IngridientBut_Click(object sender, EventArgs e)
        {
            IngredientsForm ingredients = new IngredientsForm();
            ingredients.Show();
            this.Hide();
        }
    }
}
