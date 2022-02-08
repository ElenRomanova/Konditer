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
    public partial class ProviderForm : Form
    {
        PastryShopEntities db = new PastryShopEntities();
        int id;
        string NameProvider, adress, tephone, Email;

        public ProviderForm()
        {
            InitializeComponent();
        }
        public void Dop()
        {
            TableProvider.DataSource = db.provider.ToList();
            TableProvider.Columns[0].Visible = false;
            TableProvider.Columns[5].Visible = false;
            TableProvider.Columns[1].HeaderText = "Наименовение";
            TableProvider.Columns[2].HeaderText = "Адрес";
            TableProvider.Columns[3].HeaderText = "Телефон";

            //if (TableProvider.Rows.Count > 0)
            //{
                id = Convert.ToInt32(TableProvider[0, 0].Value);

            //}
            //else
            //{
            //    MessageBox.Show("Выберите строку!");
            //}
        }

        private void ProviderForm_Load(object sender, EventArgs e)
        {
            Dop();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new CreateProvider().Show();
            this.ShowInTaskbar = false;
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            this.Close();
            MineMenu mineMenu = new MineMenu();
            mineMenu.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить данного поставщика?", null, MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                provider providerDel = db.provider.Where(p => p.IdProvider == id).FirstOrDefault();
                db.provider.Remove(providerDel);
                db.SaveChanges();
                Dop();
            }
       

        }

        private void TableProvider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(TableProvider[0, e.RowIndex].Value);
                NameProvider = TableProvider[1, e.RowIndex].Value.ToString();
                adress = TableProvider[2, e.RowIndex].Value.ToString();
                tephone = TableProvider[3, e.RowIndex].Value.ToString();
                Email = TableProvider[4, e.RowIndex].Value.ToString();

            }
            catch { }
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            UpdateProvider updateProvider = new UpdateProvider(id,NameProvider, adress, tephone,Email);
            this.Visible = false;
            updateProvider.Show();
            this.ShowInTaskbar = false;
        }
    }
}
