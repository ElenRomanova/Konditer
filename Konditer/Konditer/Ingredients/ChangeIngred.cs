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
    public partial class ChangeIngred : Form
    {
        PastryShopEntities db = new PastryShopEntities();
        int idIng;
        Ingredients ingredients;
        public ChangeIngred(int id)
        {
            InitializeComponent();
            idIng = id;
        }

        private void ProviderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != string.Empty && txtPrice.Text != string.Empty && txtMasa.Text != string.Empty)
                {
                    Ingredients ingredients = db.Ingredients.Where(p => p.IdIngredients == idIng).FirstOrDefault();
                    ingredients.Name = txtName.Text;
                    ingredients.Price = Convert.ToDecimal(txtPrice.Text);
                    ingredients.Weight = Convert.ToDouble(txtMasa.Text);
                    ingredients.IdProvder = Convert.ToInt32(comBoxProv.SelectedValue);
                    ingredients.IdUnitMeasurement = Convert.ToInt32(ComBoxEd.SelectedValue);
                    db.SaveChanges();
                    MessageBox.Show("Вы успешно обновили данные об ингредиенте!");
                    this.Close();
                    IngredientsForm ingr = new IngredientsForm();
                    ingr.IngredientTable();
                    ingr.Visible = true;
                    ingr.ShowInTaskbar = true;
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

        private void ChangeIngred_Load(object sender, EventArgs e)
        {
            Ingredients ingredients = db.Ingredients.Where(p => p.IdIngredients == idIng).FirstOrDefault();
            txtName.Text = ingredients.Name.ToString();
            txtMasa.Text = ingredients.Weight.ToString();
            txtPrice.Text = ingredients.Price.ToString();

            var TablePr = db.provider.ToList();
            var TableUnit = db.UnitMeasurement.ToList();
            ComBoxEd.DataSource = TableUnit;
            ComBoxEd.DisplayMember = "Name";
            ComBoxEd.ValueMember = "IdUnitMeasurement";
            ComBoxEd.SelectedIndex = ingredients.IdUnitMeasurement - 1;
            comBoxProv.DataSource = TablePr;
            comBoxProv.DisplayMember = "Name";
            comBoxProv.ValueMember = "IdProvider";
            comBoxProv.SelectedValue = ingredients.provider.IdProvider;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            IngredientsForm ingredients = new IngredientsForm();
            ingredients.ShowInTaskbar = true;
            ingredients.Visible = true;
        }
    }
}
