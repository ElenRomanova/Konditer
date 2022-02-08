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
    public partial class CompositionForm : Form
    {
        PastryShopEntities db = new PastryShopEntities();
        int id, idCom, idIngred;
        public CompositionForm(int IDProd)
        {
            InitializeComponent();
            id = IDProd;
        }

        public void UpdateIng()
        {
            try
            {
                var inf = from c in db.Composition
                          join ing in db.Ingredients on c.IdIngredients equals ing.IdIngredients
                          join Prod in db.Product on c.IdProduct equals Prod.IdProduct
                          where Prod.IdProduct == id
                          select new
                          {
                              idcom = c.IdComposition,
                              iding = c.IdIngredients,
                              idprod = c.IdProduct,
                              namePr = Prod.Name,
                              ingrName = ing.Name
                          };

                TableComp.DataSource = inf.ToList();
                if (TableComp.Rows.Count > 0)
                {
                    TableComp.Columns[0].Visible = false;
                    TableComp.Columns[1].Visible = false;
                    TableComp.Columns[2].Visible = false;
                    TableComp.Columns[3].HeaderText = "Наименование продукта";
                    TableComp.Columns[4].HeaderText = "Наименование ингредиент";


                    idCom = Convert.ToInt32(TableComp[0, 0].Value);


                }
                else
                {
                    TableComp.Columns[0].Visible = false;
                    TableComp.Columns[1].Visible = false;
                    TableComp.Columns[2].Visible = false;
                    TableComp.Columns[3].HeaderText = "Наименование продукта";
                    TableComp.Columns[4].HeaderText = "Наименование ингредиент";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CompositionForm_Load(object sender, EventArgs e)
        {
            UpdateIng();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AddIng addIng = new AddIng(id);
            addIng.ShowInTaskbar = true;
            addIng.Visible = true;
        }

        private void TableComp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(TableComp[2, e.RowIndex].Value);
                idCom = Convert.ToInt32(TableComp[0, e.RowIndex].Value);
                idIngred = Convert.ToInt32(TableComp[1, e.RowIndex].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(idIngred.ToString());
            this.Close();
            ChangeIngComp changeIng = new ChangeIngComp(id, idCom, idIngred);
            changeIng.ShowInTaskbar = true;
            changeIng.Visible = true;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить данный ингредент?", null, MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Composition composition = db.Composition.Where(p => p.IdComposition == idCom).FirstOrDefault();
                db.Composition.Remove(composition);
                db.SaveChanges();
                UpdateIng();

            }
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            {
                this.Close();
                ProductForm product = new ProductForm();
                product.ShowInTaskbar = true;
                product.Visible = true;
            }
        }
    }
}
