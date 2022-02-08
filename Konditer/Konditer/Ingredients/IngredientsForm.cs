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
    public partial class IngredientsForm : Form
    {
        PastryShopEntities db = new PastryShopEntities();
        int id;
        string NameIngredient, NameProvider, UnitM, PriceIng, WeightIng;

        public IngredientsForm()
        {
            InitializeComponent();
        }
        public void IngredientTable()
        {
            try
            {
                var vivodIn = from u in db.Ingredients
                              join pr in db.provider on u.IdProvder equals pr.IdProvider
                              join mes in db.UnitMeasurement on u.IdUnitMeasurement equals mes.IdUnitMeasurement
                              //join prod in db.Composition  on u.IdIngredients equals prod.IdIngredients
                              select new { idIng= u.IdIngredients, Name = u.Name, NameProv = pr.Name,
                                  NameUnt = mes.Name, PriceIn = u.Price, Weigth = u.Weight/*, NameProd=prod.IdProduct*/ };
                    TableIngred.DataSource = vivodIn.ToList(); /*db.Ingredients.ToList();*/

                //DataTable dataTable = new DataTable();
                //TableIngred.DataSource
                if (TableIngred.Rows.Count > 0)
                {
                    TableIngred.Columns[0].Visible = false;
                    //TableIngred.Columns[8].Visible = false;
                    //TableIngred.Columns[6].Visible = false;
                    //TableIngred.Columns[7].Visible = false;

                    TableIngred.Columns[1].HeaderText = "Наименовение";
                    TableIngred.Columns[2].HeaderText = "Поставщик";
                    TableIngred.Columns[3].HeaderText = "Ед.измерения";
                    TableIngred.Columns[4].HeaderText = "Цена";
                    TableIngred.Columns[5].HeaderText = "Вес";

                    id = Convert.ToInt32(TableIngred[0, 0].Value);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void IngredientsForm_Load(object sender, EventArgs e)
        {
            IngredientTable();
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new ChangeIngred(id).Show();
            this.ShowInTaskbar = false;
        }

        private void TableIngred_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить данный ингредент?", null, MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Ingredients ingredients = db.Ingredients.Where(p => p.IdIngredients == id).FirstOrDefault();
                db.Ingredients.Remove(ingredients);
                db.SaveChanges();
                IngredientTable();

            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
    

            this.Visible = false;
            new CreateIngred().Show();
            this.ShowInTaskbar = false;
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            this.Close();
            MineMenu mineMenu = new MineMenu();
            mineMenu.Show();
        }

        private void TableIngred_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(TableIngred[0, e.RowIndex].Value);
                //NameIngredient = TableIngred[1, e.RowIndex].Value.ToString();
                //NameProvider = TableIngred[2, e.RowIndex].Value.ToString();
                //UnitM = TableIngred[3, e.RowIndex].Value.ToString();
                //PriceIng = TableIngred[4, e.RowIndex].Value.ToString();
                //WeightIng = TableIngred[4, e.RowIndex].Value.ToString();

            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
