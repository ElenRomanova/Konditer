using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Konditer
{
    public partial class CreateProvider : Form
    {
        PastryShopEntities db = new PastryShopEntities();

        public CreateProvider()
        {
            InitializeComponent();
        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ProviderForm provider = new ProviderForm();
            provider.ShowInTaskbar = true;
            provider.Visible = true;

        }

        //bool isvalid(string Email)
        //{
          
        //    try
        //    {
        //        string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
        //        Match isMatch = Regex.Match(Email, pattern, RegexOptions.IgnoreCase);
        //        return isMatch.Success;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Некорректный ввод адреса!");
        //        return false;
        //    }
        //}

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try {
                if (txtName.Text!="" && txtAdress.Text != "" && txtPhone.Text != "" && txtEmail.Text!="") {
                    string name, adress, phonel, email;
                    name = txtName.Text;
                    adress = txtAdress.Text;
                    phonel = txtPhone.Text;
                    email = txtEmail.Text;

                    string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
                    if (Regex.IsMatch(email, pattern)) {

                        provider Provider = new provider { Name = name, Adress = adress, Email = email, Telephone = phonel };
                        db.provider.Add(Provider);
                        db.SaveChanges();
                        MessageBox.Show("Вы успешно добавили поставщика!");

                        ProviderForm provider = new ProviderForm();
                        provider.Visible = true;
                        provider.Dop();
                        this.ShowInTaskbar = false;
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Некорректный ввод адреса!");
                    }

                    //isvalid(email);

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
