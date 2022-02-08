using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Konditer
{
    public partial class UpdateProvider : Form
    {
        PastryShopEntities db = new PastryShopEntities();
        int idProv;
        public UpdateProvider(int id, string nemePr, string email, string adress, string phone)
        {
            InitializeComponent();
            idProv = id;
            nametxt.Text = nemePr;
            txtAdress.Text = adress;
            txtEmail.Text = email;
            Phonetxt.Text = phone;
        }

        private void ProviderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nametxt.Text != "" && txtAdress.Text != "" && Phonetxt.Text != "" && txtEmail.Text != "")
                {
                    string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
                    if (Regex.IsMatch(txtEmail.Text, pattern))
                    {

                        provider Provider = db.provider.Where(p => p.IdProvider == idProv).FirstOrDefault();
                        Provider.Name = nametxt.Text;
                        Provider.Telephone = Phonetxt.Text;
                        Provider.Adress = txtAdress.Text;
                        Provider.Email = txtEmail.Text;
                        db.SaveChanges();
                        MessageBox.Show("Вы успешно обновили данные об поставщике!");
                        this.Close();
                        ProviderForm provider = new ProviderForm();
                        provider.Dop();
                        provider.Visible = true;
                        provider.ShowInTaskbar = true;
                    }
                    else
                    {
                        MessageBox.Show("Некорректный ввод адреса!");
                    }
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
    }
}
