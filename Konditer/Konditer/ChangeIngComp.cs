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
    public partial class ChangeIngComp : Form
    {
        PastryShopEntities db = new PastryShopEntities();
        int IdComp, idIng, id;
        public ChangeIngComp(int Id,int IDComp,int IDIng)
        {
            InitializeComponent();
            IdComp = IDComp;
            idIng = IDIng;
            id = Id;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Composition composition = db.Composition.Where(p => p.IdComposition == IdComp).FirstOrDefault();
                //composition = db.Composition.Where(p => p.IdIngredients == idIng).FirstOrDefault();

                composition.IdIngredients = Convert.ToInt32(ComBoxProvider.SelectedValue);
                db.SaveChanges();
                MessageBox.Show("Вы успешно изменили ингредиент!");
                this.Close();

                CompositionForm compositionForm = new CompositionForm(id);
                compositionForm.UpdateIng();

                compositionForm.Visible = true;
                compositionForm.ShowInTaskbar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void ChangeIngComp_Load(object sender, EventArgs e)
        {
           Composition composition = db.Composition.Where(p => p.IdComposition == IdComp).FirstOrDefault();

            var TablePr = db.Ingredients.ToList();
            ComBoxProvider.DataSource = TablePr;
            ComBoxProvider.DisplayMember = "Name";
            ComBoxProvider.ValueMember = "IdIngredients";
            //ComBoxProvider.SelectedIndex = composition.IdComposition-1;

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new CompositionForm(id).Show();
        }
    }
}
