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
    public partial class AddIng : Form
    {
        PastryShopEntities db = new PastryShopEntities();
        int id;
        public AddIng(int ID)
        {
            InitializeComponent();
            id = ID;
        }

        private void AddIng_Load(object sender, EventArgs e)
        {
            var TablePr = db.Ingredients.ToList();
            ComBoxProvider.DataSource = TablePr;
            ComBoxProvider.DisplayMember = "Name";
            ComBoxProvider.ValueMember = "IdIngredients";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new CompositionForm(id).Show();

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int idProv;
             
                idProv = Convert.ToInt32(ComBoxProvider.SelectedValue);
                Composition comp = new Composition { IdProduct = id, IdIngredients = idProv };
            
                db.Composition.Add(comp);
                db.SaveChanges();
                MessageBox.Show("Вы успешно добавили ингредиент");
                CompositionForm ingredients = new CompositionForm(id);
                this.Close();
                ingredients.UpdateIng();
                ingredients.Visible = true;
                ingredients.ShowInTaskbar = true;

                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
