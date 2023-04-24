using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string userName = "admin";
        string password = "admin";

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (userName.Equals(txt_kullaniciAdi.Text) && password.Equals(txt_sifre.Text))
            {
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void lbl_musteri_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Customer customer = new Customer();
            customer.Show();
            
        }
    }
}
