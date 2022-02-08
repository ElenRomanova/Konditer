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
    public partial class CreateIngred : Form
    {
        PastryShopEntities db = new PastryShopEntities();


        public CreateIngred()
        {
            InitializeComponent();
        }



        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
           IngredientsForm ingredients = new IngredientsForm();
            ingredients.ShowInTaskbar = true;
            ingredients.Visible = true;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != string.Empty && txtPrice.Text != string.Empty && txtMasa.Text != string.Empty)
                {
                    string name;
                    decimal Price;
                    double weight; 
                    int idUnit, idProv;
                    name = txtName.Text;
                    Price = Convert.ToDecimal(txtPrice.Text);
                    weight = Convert.ToDouble(txtMasa.Text);
                    idUnit = Convert.ToInt32(comBoxEd.SelectedValue);
                    idProv = Convert.ToInt32(ComBoxProvider.SelectedValue);
                    Ingredients ing = new Ingredients { Name = name, Price=Price, Weight=weight, IdUnitMeasurement=idUnit, IdProvder=idProv};

                    //Ingredients ing = new Ingredients
                    //{
                    //    Name = Convert.ToString(txtName.Text),
                    //    Price = Convert.ToDecimal(txtPrice.Text),
                    //    Weight = Convert.ToDouble(txtMasa.Text),

                    //    IdUnitMeasurement = Convert.ToInt32(comBoxEd.Text),
                    //    IdProvder = Convert.ToInt32(ComBoxProvider.Text)
                    //};
                    db.Ingredients.Add(ing);
                db.SaveChanges();
                    MessageBox.Show("Вы успешно добавили ингредиент");
                    IngredientsForm ingredients = new IngredientsForm();
                this.Close();
                ingredients.IngredientTable();
                    ingredients.Visible = true;
                    ingredients.ShowInTaskbar = true;

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
                

        private void CreateIngred_Load(object sender, EventArgs e)
        {
            var TablePr = db.provider.ToList();
            var TableUnit = db.UnitMeasurement.ToList();
            comBoxEd.DataSource = TableUnit;
            comBoxEd.DisplayMember = "Name";
            comBoxEd.ValueMember = "IdUnitMeasurement";

            ComBoxProvider.DataSource = TablePr;
            ComBoxProvider.DisplayMember = "Name";
            ComBoxProvider.ValueMember = "IdProvider";
        }
    }
}
